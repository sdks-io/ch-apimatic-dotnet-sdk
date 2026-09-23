using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackNumberChartConfigConverter))]
public record ClickStackNumberChartConfig
{
    private readonly Optional<ClickStackNumberBuilderChartConfig> _clickStackNumberBuilderChartConfigValue;

    private readonly Optional<ClickStackNumberRawSqlChartConfig> _clickStackNumberRawSqlChartConfigValue;

    private ClickStackNumberChartConfig(Optional<ClickStackNumberBuilderChartConfig> clickStackNumberBuilderChartConfigValue,
        Optional<ClickStackNumberRawSqlChartConfig> clickStackNumberRawSqlChartConfigValue)
    {
        _clickStackNumberBuilderChartConfigValue = clickStackNumberBuilderChartConfigValue;
        _clickStackNumberRawSqlChartConfigValue = clickStackNumberRawSqlChartConfigValue;
    }

    public static ClickStackNumberChartConfig ClickStackNumberBuilderChartConfig(ClickStackNumberBuilderChartConfig value) =>
        new(Optional<ClickStackNumberBuilderChartConfig>.Some(value), default);

    public static ClickStackNumberChartConfig ClickStackNumberRawSqlChartConfig(ClickStackNumberRawSqlChartConfig value) =>
        new(default, Optional<ClickStackNumberRawSqlChartConfig>.Some(value));

    public bool TryGetClickStackNumberBuilderChartConfig(out ClickStackNumberBuilderChartConfig value) =>
        _clickStackNumberBuilderChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackNumberRawSqlChartConfig(out ClickStackNumberRawSqlChartConfig value) =>
        _clickStackNumberRawSqlChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackNumberChartConfig(ClickStackNumberBuilderChartConfig value) =>
        ClickStackNumberBuilderChartConfig(value);

    public static implicit operator ClickStackNumberChartConfig(ClickStackNumberRawSqlChartConfig value) =>
        ClickStackNumberRawSqlChartConfig(value);
}

file sealed class ClickStackNumberChartConfigConverter : JsonConverter<ClickStackNumberChartConfig>
{
    public override ClickStackNumberChartConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackNumberBuilderChartConfig>(root,
            options,
            out var clickStackNumberBuilderChartConfigValue))
        {
            return ClickStackNumberChartConfig.ClickStackNumberBuilderChartConfig(clickStackNumberBuilderChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackNumberRawSqlChartConfig>(root,
            options,
            out var clickStackNumberRawSqlChartConfigValue))
        {
            return ClickStackNumberChartConfig.ClickStackNumberRawSqlChartConfig(clickStackNumberRawSqlChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackNumberBuilderChartConfig or ClickStackNumberRawSqlChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackNumberChartConfig value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackNumberBuilderChartConfig(out var clickStackNumberBuilderChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackNumberBuilderChartConfigValue, options);
        }
        else if (value.TryGetClickStackNumberRawSqlChartConfig(out var clickStackNumberRawSqlChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackNumberRawSqlChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackNumberChartConfig)} contains no valid value to serialize.");
        }
    }
}
