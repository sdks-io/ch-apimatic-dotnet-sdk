using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackBarChartConfigConverter))]
public record ClickStackBarChartConfig
{
    private readonly Optional<ClickStackBarBuilderChartConfig> _clickStackBarBuilderChartConfigValue;

    private readonly Optional<ClickStackBarRawSqlChartConfig> _clickStackBarRawSqlChartConfigValue;

    private ClickStackBarChartConfig(Optional<ClickStackBarBuilderChartConfig> clickStackBarBuilderChartConfigValue,
        Optional<ClickStackBarRawSqlChartConfig> clickStackBarRawSqlChartConfigValue)
    {
        _clickStackBarBuilderChartConfigValue = clickStackBarBuilderChartConfigValue;
        _clickStackBarRawSqlChartConfigValue = clickStackBarRawSqlChartConfigValue;
    }

    public static ClickStackBarChartConfig ClickStackBarBuilderChartConfig(ClickStackBarBuilderChartConfig value) =>
        new(Optional<ClickStackBarBuilderChartConfig>.Some(value), default);

    public static ClickStackBarChartConfig ClickStackBarRawSqlChartConfig(ClickStackBarRawSqlChartConfig value) =>
        new(default, Optional<ClickStackBarRawSqlChartConfig>.Some(value));

    public bool TryGetClickStackBarBuilderChartConfig(out ClickStackBarBuilderChartConfig value) =>
        _clickStackBarBuilderChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackBarRawSqlChartConfig(out ClickStackBarRawSqlChartConfig value) =>
        _clickStackBarRawSqlChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackBarChartConfig(ClickStackBarBuilderChartConfig value) =>
        ClickStackBarBuilderChartConfig(value);

    public static implicit operator ClickStackBarChartConfig(ClickStackBarRawSqlChartConfig value) =>
        ClickStackBarRawSqlChartConfig(value);
}

file sealed class ClickStackBarChartConfigConverter : JsonConverter<ClickStackBarChartConfig>
{
    public override ClickStackBarChartConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackBarBuilderChartConfig>(root,
            options,
            out var clickStackBarBuilderChartConfigValue))
        {
            return ClickStackBarChartConfig.ClickStackBarBuilderChartConfig(clickStackBarBuilderChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackBarRawSqlChartConfig>(root,
            options,
            out var clickStackBarRawSqlChartConfigValue))
        {
            return ClickStackBarChartConfig.ClickStackBarRawSqlChartConfig(clickStackBarRawSqlChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackBarBuilderChartConfig or ClickStackBarRawSqlChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackBarChartConfig value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackBarBuilderChartConfig(out var clickStackBarBuilderChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackBarBuilderChartConfigValue, options);
        }
        else if (value.TryGetClickStackBarRawSqlChartConfig(out var clickStackBarRawSqlChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackBarRawSqlChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackBarChartConfig)} contains no valid value to serialize.");
        }
    }
}
