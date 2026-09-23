using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackCategoricalBarChartConfigConverter))]
public record ClickStackCategoricalBarChartConfig
{
    private readonly Optional<ClickStackCategoricalBarBuilderChartConfig> _clickStackCategoricalBarBuilderChartConfigValue;

    private readonly Optional<ClickStackCategoricalBarRawSqlChartConfig> _clickStackCategoricalBarRawSqlChartConfigValue;

    private ClickStackCategoricalBarChartConfig(Optional<ClickStackCategoricalBarBuilderChartConfig> clickStackCategoricalBarBuilderChartConfigValue,
        Optional<ClickStackCategoricalBarRawSqlChartConfig> clickStackCategoricalBarRawSqlChartConfigValue)
    {
        _clickStackCategoricalBarBuilderChartConfigValue = clickStackCategoricalBarBuilderChartConfigValue;
        _clickStackCategoricalBarRawSqlChartConfigValue = clickStackCategoricalBarRawSqlChartConfigValue;
    }

    public static ClickStackCategoricalBarChartConfig ClickStackCategoricalBarBuilderChartConfig(ClickStackCategoricalBarBuilderChartConfig value) =>
        new(Optional<ClickStackCategoricalBarBuilderChartConfig>.Some(value), default);

    public static ClickStackCategoricalBarChartConfig ClickStackCategoricalBarRawSqlChartConfig(ClickStackCategoricalBarRawSqlChartConfig value) =>
        new(default, Optional<ClickStackCategoricalBarRawSqlChartConfig>.Some(value));

    public bool TryGetClickStackCategoricalBarBuilderChartConfig(out ClickStackCategoricalBarBuilderChartConfig value) =>
        _clickStackCategoricalBarBuilderChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackCategoricalBarRawSqlChartConfig(out ClickStackCategoricalBarRawSqlChartConfig value) =>
        _clickStackCategoricalBarRawSqlChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackCategoricalBarChartConfig(ClickStackCategoricalBarBuilderChartConfig value) =>
        ClickStackCategoricalBarBuilderChartConfig(value);

    public static implicit operator ClickStackCategoricalBarChartConfig(ClickStackCategoricalBarRawSqlChartConfig value) =>
        ClickStackCategoricalBarRawSqlChartConfig(value);
}

file sealed class ClickStackCategoricalBarChartConfigConverter : JsonConverter<ClickStackCategoricalBarChartConfig>
{
    public override ClickStackCategoricalBarChartConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackCategoricalBarBuilderChartConfig>(root,
            options,
            out var clickStackCategoricalBarBuilderChartConfigValue))
        {
            return ClickStackCategoricalBarChartConfig.ClickStackCategoricalBarBuilderChartConfig(clickStackCategoricalBarBuilderChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackCategoricalBarRawSqlChartConfig>(root,
            options,
            out var clickStackCategoricalBarRawSqlChartConfigValue))
        {
            return ClickStackCategoricalBarChartConfig.ClickStackCategoricalBarRawSqlChartConfig(clickStackCategoricalBarRawSqlChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackCategoricalBarBuilderChartConfig or ClickStackCategoricalBarRawSqlChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackCategoricalBarChartConfig value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackCategoricalBarBuilderChartConfig(out var clickStackCategoricalBarBuilderChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackCategoricalBarBuilderChartConfigValue, options);
        }
        else if (value.TryGetClickStackCategoricalBarRawSqlChartConfig(out var clickStackCategoricalBarRawSqlChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackCategoricalBarRawSqlChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackCategoricalBarChartConfig)} contains no valid value to serialize.");
        }
    }
}
