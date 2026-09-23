using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackLineChartConfigConverter))]
public record ClickStackLineChartConfig
{
    private readonly Optional<ClickStackLineBuilderChartConfig> _clickStackLineBuilderChartConfigValue;

    private readonly Optional<ClickStackLineRawSqlChartConfig> _clickStackLineRawSqlChartConfigValue;

    private ClickStackLineChartConfig(Optional<ClickStackLineBuilderChartConfig> clickStackLineBuilderChartConfigValue,
        Optional<ClickStackLineRawSqlChartConfig> clickStackLineRawSqlChartConfigValue)
    {
        _clickStackLineBuilderChartConfigValue = clickStackLineBuilderChartConfigValue;
        _clickStackLineRawSqlChartConfigValue = clickStackLineRawSqlChartConfigValue;
    }

    public static ClickStackLineChartConfig ClickStackLineBuilderChartConfig(ClickStackLineBuilderChartConfig value) =>
        new(Optional<ClickStackLineBuilderChartConfig>.Some(value), default);

    public static ClickStackLineChartConfig ClickStackLineRawSqlChartConfig(ClickStackLineRawSqlChartConfig value) =>
        new(default, Optional<ClickStackLineRawSqlChartConfig>.Some(value));

    public bool TryGetClickStackLineBuilderChartConfig(out ClickStackLineBuilderChartConfig value) =>
        _clickStackLineBuilderChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackLineRawSqlChartConfig(out ClickStackLineRawSqlChartConfig value) =>
        _clickStackLineRawSqlChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackLineChartConfig(ClickStackLineBuilderChartConfig value) =>
        ClickStackLineBuilderChartConfig(value);

    public static implicit operator ClickStackLineChartConfig(ClickStackLineRawSqlChartConfig value) =>
        ClickStackLineRawSqlChartConfig(value);
}

file sealed class ClickStackLineChartConfigConverter : JsonConverter<ClickStackLineChartConfig>
{
    public override ClickStackLineChartConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackLineBuilderChartConfig>(root,
            options,
            out var clickStackLineBuilderChartConfigValue))
        {
            return ClickStackLineChartConfig.ClickStackLineBuilderChartConfig(clickStackLineBuilderChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackLineRawSqlChartConfig>(root,
            options,
            out var clickStackLineRawSqlChartConfigValue))
        {
            return ClickStackLineChartConfig.ClickStackLineRawSqlChartConfig(clickStackLineRawSqlChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackLineBuilderChartConfig or ClickStackLineRawSqlChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackLineChartConfig value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackLineBuilderChartConfig(out var clickStackLineBuilderChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackLineBuilderChartConfigValue, options);
        }
        else if (value.TryGetClickStackLineRawSqlChartConfig(out var clickStackLineRawSqlChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackLineRawSqlChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackLineChartConfig)} contains no valid value to serialize.");
        }
    }
}
