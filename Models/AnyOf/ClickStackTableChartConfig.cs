using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackTableChartConfigConverter))]
public record ClickStackTableChartConfig
{
    private readonly Optional<ClickStackTableBuilderChartConfig> _clickStackTableBuilderChartConfigValue;

    private readonly Optional<ClickStackTableRawSqlChartConfig> _clickStackTableRawSqlChartConfigValue;

    private ClickStackTableChartConfig(Optional<ClickStackTableBuilderChartConfig> clickStackTableBuilderChartConfigValue,
        Optional<ClickStackTableRawSqlChartConfig> clickStackTableRawSqlChartConfigValue)
    {
        _clickStackTableBuilderChartConfigValue = clickStackTableBuilderChartConfigValue;
        _clickStackTableRawSqlChartConfigValue = clickStackTableRawSqlChartConfigValue;
    }

    public static ClickStackTableChartConfig ClickStackTableBuilderChartConfig(ClickStackTableBuilderChartConfig value) =>
        new(Optional<ClickStackTableBuilderChartConfig>.Some(value), default);

    public static ClickStackTableChartConfig ClickStackTableRawSqlChartConfig(ClickStackTableRawSqlChartConfig value) =>
        new(default, Optional<ClickStackTableRawSqlChartConfig>.Some(value));

    public bool TryGetClickStackTableBuilderChartConfig(out ClickStackTableBuilderChartConfig value) =>
        _clickStackTableBuilderChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackTableRawSqlChartConfig(out ClickStackTableRawSqlChartConfig value) =>
        _clickStackTableRawSqlChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackTableChartConfig(ClickStackTableBuilderChartConfig value) =>
        ClickStackTableBuilderChartConfig(value);

    public static implicit operator ClickStackTableChartConfig(ClickStackTableRawSqlChartConfig value) =>
        ClickStackTableRawSqlChartConfig(value);
}

file sealed class ClickStackTableChartConfigConverter : JsonConverter<ClickStackTableChartConfig>
{
    public override ClickStackTableChartConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackTableBuilderChartConfig>(root,
            options,
            out var clickStackTableBuilderChartConfigValue))
        {
            return ClickStackTableChartConfig.ClickStackTableBuilderChartConfig(clickStackTableBuilderChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackTableRawSqlChartConfig>(root,
            options,
            out var clickStackTableRawSqlChartConfigValue))
        {
            return ClickStackTableChartConfig.ClickStackTableRawSqlChartConfig(clickStackTableRawSqlChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackTableBuilderChartConfig or ClickStackTableRawSqlChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackTableChartConfig value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackTableBuilderChartConfig(out var clickStackTableBuilderChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackTableBuilderChartConfigValue, options);
        }
        else if (value.TryGetClickStackTableRawSqlChartConfig(out var clickStackTableRawSqlChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackTableRawSqlChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackTableChartConfig)} contains no valid value to serialize.");
        }
    }
}
