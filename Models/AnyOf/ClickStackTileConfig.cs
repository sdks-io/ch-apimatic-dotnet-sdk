using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackTileConfigConverter))]
public record ClickStackTileConfig
{
    private readonly Optional<ClickStackLineChartConfig> _clickStackLineChartConfigValue;

    private readonly Optional<ClickStackBarChartConfig> _clickStackBarChartConfigValue;

    private readonly Optional<ClickStackTableChartConfig> _clickStackTableChartConfigValue;

    private readonly Optional<ClickStackNumberChartConfig> _clickStackNumberChartConfigValue;

    private readonly Optional<ClickStackPieChartConfig> _clickStackPieChartConfigValue;

    private readonly Optional<ClickStackCategoricalBarChartConfig> _clickStackCategoricalBarChartConfigValue;

    private readonly Optional<ClickStackHeatmapChartConfig> _clickStackHeatmapChartConfigValue;

    private readonly Optional<ClickStackSearchChartConfig> _clickStackSearchChartConfigValue;

    private readonly Optional<ClickStackEventPatternsChartConfig> _clickStackEventPatternsChartConfigValue;

    private readonly Optional<ClickStackMarkdownChartConfig> _clickStackMarkdownChartConfigValue;

    private ClickStackTileConfig(Optional<ClickStackLineChartConfig> clickStackLineChartConfigValue,
        Optional<ClickStackBarChartConfig> clickStackBarChartConfigValue,
        Optional<ClickStackTableChartConfig> clickStackTableChartConfigValue,
        Optional<ClickStackNumberChartConfig> clickStackNumberChartConfigValue,
        Optional<ClickStackPieChartConfig> clickStackPieChartConfigValue,
        Optional<ClickStackCategoricalBarChartConfig> clickStackCategoricalBarChartConfigValue,
        Optional<ClickStackHeatmapChartConfig> clickStackHeatmapChartConfigValue,
        Optional<ClickStackSearchChartConfig> clickStackSearchChartConfigValue,
        Optional<ClickStackEventPatternsChartConfig> clickStackEventPatternsChartConfigValue,
        Optional<ClickStackMarkdownChartConfig> clickStackMarkdownChartConfigValue)
    {
        _clickStackLineChartConfigValue = clickStackLineChartConfigValue;
        _clickStackBarChartConfigValue = clickStackBarChartConfigValue;
        _clickStackTableChartConfigValue = clickStackTableChartConfigValue;
        _clickStackNumberChartConfigValue = clickStackNumberChartConfigValue;
        _clickStackPieChartConfigValue = clickStackPieChartConfigValue;
        _clickStackCategoricalBarChartConfigValue = clickStackCategoricalBarChartConfigValue;
        _clickStackHeatmapChartConfigValue = clickStackHeatmapChartConfigValue;
        _clickStackSearchChartConfigValue = clickStackSearchChartConfigValue;
        _clickStackEventPatternsChartConfigValue = clickStackEventPatternsChartConfigValue;
        _clickStackMarkdownChartConfigValue = clickStackMarkdownChartConfigValue;
    }

    public static ClickStackTileConfig ClickStackLineChartConfig(ClickStackLineChartConfig value) =>
        new(Optional<ClickStackLineChartConfig>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackBarChartConfig(ClickStackBarChartConfig value) =>
        new(default,
            Optional<ClickStackBarChartConfig>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackTableChartConfig(ClickStackTableChartConfig value) =>
        new(default,
            default,
            Optional<ClickStackTableChartConfig>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackNumberChartConfig(ClickStackNumberChartConfig value) =>
        new(default,
            default,
            default,
            Optional<ClickStackNumberChartConfig>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackPieChartConfig(ClickStackPieChartConfig value) =>
        new(default,
            default,
            default,
            default,
            Optional<ClickStackPieChartConfig>.Some(value),
            default,
            default,
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackCategoricalBarChartConfig(ClickStackCategoricalBarChartConfig value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<ClickStackCategoricalBarChartConfig>.Some(value),
            default,
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackHeatmapChartConfig(ClickStackHeatmapChartConfig value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            Optional<ClickStackHeatmapChartConfig>.Some(value),
            default,
            default,
            default);

    public static ClickStackTileConfig ClickStackSearchChartConfig(ClickStackSearchChartConfig value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<ClickStackSearchChartConfig>.Some(value),
            default,
            default);

    public static ClickStackTileConfig ClickStackEventPatternsChartConfig(ClickStackEventPatternsChartConfig value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<ClickStackEventPatternsChartConfig>.Some(value),
            default);

    public static ClickStackTileConfig ClickStackMarkdownChartConfig(ClickStackMarkdownChartConfig value) =>
        new(default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            default,
            Optional<ClickStackMarkdownChartConfig>.Some(value));

    public bool TryGetClickStackLineChartConfig(out ClickStackLineChartConfig value) =>
        _clickStackLineChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackBarChartConfig(out ClickStackBarChartConfig value) =>
        _clickStackBarChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackTableChartConfig(out ClickStackTableChartConfig value) =>
        _clickStackTableChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackNumberChartConfig(out ClickStackNumberChartConfig value) =>
        _clickStackNumberChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackPieChartConfig(out ClickStackPieChartConfig value) =>
        _clickStackPieChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackCategoricalBarChartConfig(out ClickStackCategoricalBarChartConfig value) =>
        _clickStackCategoricalBarChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackHeatmapChartConfig(out ClickStackHeatmapChartConfig value) =>
        _clickStackHeatmapChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackSearchChartConfig(out ClickStackSearchChartConfig value) =>
        _clickStackSearchChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackEventPatternsChartConfig(out ClickStackEventPatternsChartConfig value) =>
        _clickStackEventPatternsChartConfigValue.TryGetValue(out value);

    public bool TryGetClickStackMarkdownChartConfig(out ClickStackMarkdownChartConfig value) =>
        _clickStackMarkdownChartConfigValue.TryGetValue(out value);

    public static implicit operator ClickStackTileConfig(ClickStackLineChartConfig value) =>
        ClickStackLineChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackBarChartConfig value) =>
        ClickStackBarChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackTableChartConfig value) =>
        ClickStackTableChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackNumberChartConfig value) =>
        ClickStackNumberChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackPieChartConfig value) =>
        ClickStackPieChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackCategoricalBarChartConfig value) =>
        ClickStackCategoricalBarChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackHeatmapChartConfig value) =>
        ClickStackHeatmapChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackSearchChartConfig value) =>
        ClickStackSearchChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackEventPatternsChartConfig value) =>
        ClickStackEventPatternsChartConfig(value);

    public static implicit operator ClickStackTileConfig(ClickStackMarkdownChartConfig value) =>
        ClickStackMarkdownChartConfig(value);
}

file sealed class ClickStackTileConfigConverter : JsonConverter<ClickStackTileConfig>
{
    public override ClickStackTileConfig Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackLineChartConfig>(root,
            options,
            out var clickStackLineChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackLineChartConfig(clickStackLineChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackBarChartConfig>(root,
            options,
            out var clickStackBarChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackBarChartConfig(clickStackBarChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackTableChartConfig>(root,
            options,
            out var clickStackTableChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackTableChartConfig(clickStackTableChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackNumberChartConfig>(root,
            options,
            out var clickStackNumberChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackNumberChartConfig(clickStackNumberChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackPieChartConfig>(root,
            options,
            out var clickStackPieChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackPieChartConfig(clickStackPieChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackCategoricalBarChartConfig>(root,
            options,
            out var clickStackCategoricalBarChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackCategoricalBarChartConfig(clickStackCategoricalBarChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackHeatmapChartConfig>(root,
            options,
            out var clickStackHeatmapChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackHeatmapChartConfig(clickStackHeatmapChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackSearchChartConfig>(root,
            options,
            out var clickStackSearchChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackSearchChartConfig(clickStackSearchChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackEventPatternsChartConfig>(root,
            options,
            out var clickStackEventPatternsChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackEventPatternsChartConfig(clickStackEventPatternsChartConfigValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackMarkdownChartConfig>(root,
            options,
            out var clickStackMarkdownChartConfigValue))
        {
            return ClickStackTileConfig.ClickStackMarkdownChartConfig(clickStackMarkdownChartConfigValue);
        }
        throw new JsonException($"JSON does not match ClickStackLineChartConfig or ClickStackBarChartConfig or ClickStackTableChartConfig or ClickStackNumberChartConfig or ClickStackPieChartConfig or ClickStackCategoricalBarChartConfig or ClickStackHeatmapChartConfig or ClickStackSearchChartConfig or ClickStackEventPatternsChartConfig or ClickStackMarkdownChartConfig schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackTileConfig value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackLineChartConfig(out var clickStackLineChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackLineChartConfigValue, options);
        }
        else if (value.TryGetClickStackBarChartConfig(out var clickStackBarChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackBarChartConfigValue, options);
        }
        else if (value.TryGetClickStackTableChartConfig(out var clickStackTableChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackTableChartConfigValue, options);
        }
        else if (value.TryGetClickStackNumberChartConfig(out var clickStackNumberChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackNumberChartConfigValue, options);
        }
        else if (value.TryGetClickStackPieChartConfig(out var clickStackPieChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackPieChartConfigValue, options);
        }
        else if (value.TryGetClickStackCategoricalBarChartConfig(out var clickStackCategoricalBarChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackCategoricalBarChartConfigValue, options);
        }
        else if (value.TryGetClickStackHeatmapChartConfig(out var clickStackHeatmapChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackHeatmapChartConfigValue, options);
        }
        else if (value.TryGetClickStackSearchChartConfig(out var clickStackSearchChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackSearchChartConfigValue, options);
        }
        else if (value.TryGetClickStackEventPatternsChartConfig(out var clickStackEventPatternsChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackEventPatternsChartConfigValue, options);
        }
        else if (value.TryGetClickStackMarkdownChartConfig(out var clickStackMarkdownChartConfigValue))
        {
            JsonSerializer.Serialize(writer, clickStackMarkdownChartConfigValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackTileConfig)} contains no valid value to serialize.");
        }
    }
}
