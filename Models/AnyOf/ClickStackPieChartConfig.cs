using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackPieChartConfigConverter))]
public record ClickStackPieChartConfig
{
    private readonly Optional<ClickStackPieBuilderChartConfig> _clickStackPieBuilderChartConfigValue;

    private readonly Optional<ClickStackPieRawSqlChartConfig> _clickStackPieRawSqlChartConfigValue;

    private ClickStackPieChartConfig(Optional<ClickStackPieBuilderChartConfig> clickStackPieBuilderChartConfigValue,
        Optional<ClickStackPieRawSqlChartConfig> clickStackPieRawSqlChartConfigValue)
    {
        _clickStackPieBuilderChartConfigValue = clickStackPieBuilderChartConfigValue;
        _clickStackPieRawSqlChartConfigValue = clickStackPieRawSqlChartConfigValue;
    }

    public static ClickStackPieChartConfig ClickStackPieBuilderChartConfig(ClickStackPieBuilderChartConfig value) =>
        new(Optional<ClickStackPieBuilderChartConfig>.Some(value), default);

    public static ClickStackPieChartConfig ClickStackPieRawSqlChartConfig(ClickStackPieRawSqlChartConfig value) =>
        new(default, Optional<ClickStackPieRawSqlChartConfig>.Some(value));

    public bool TryGetClickStackPieBuilderChartConfig(out ClickStackPieBuilderChartConfig value) =>
        _clickStackPieBuilderChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackPieRawSqlChartConfig(out ClickStackPieRawSqlChartConfig value) =>
        _clickStackPieRawSqlChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackPieChartConfig(ClickStackPieBuilderChartConfig value) =>
        ClickStackPieBuilderChartConfig(value);

    public static implicit operator ClickStackPieChartConfig(ClickStackPieRawSqlChartConfig value) =>
        ClickStackPieRawSqlChartConfig(value);
}

file sealed class ClickStackPieChartConfigConverter : JsonConverter<ClickStackPieChartConfig>
{
    public override ClickStackPieChartConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackPieBuilderChartConfig>(root,
            options,
            out var clickStackPieBuilderChartConfigValue))
        {
            return ClickStackPieChartConfig.ClickStackPieBuilderChartConfig(clickStackPieBuilderChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackPieRawSqlChartConfig>(root,
            options,
            out var clickStackPieRawSqlChartConfigValue))
        {
            return ClickStackPieChartConfig.ClickStackPieRawSqlChartConfig(clickStackPieRawSqlChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackPieBuilderChartConfig or ClickStackPieRawSqlChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackPieChartConfig value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackPieBuilderChartConfig(out var clickStackPieBuilderChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackPieBuilderChartConfigValue, options);
        }
        else if (value.TryGetClickStackPieRawSqlChartConfig(out var clickStackPieRawSqlChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackPieRawSqlChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackPieChartConfig)} contains no valid value to serialize.");
        }
    }
}
