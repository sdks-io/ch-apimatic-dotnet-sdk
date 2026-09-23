using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackDashboardChartSeriesConverter))]
public record ClickStackDashboardChartSeries
{
    private readonly Optional<ClickStackTimeChartSeries> _clickStackTimeChartSeriesValue;

    private readonly Optional<ClickStackTableChartSeries> _clickStackTableChartSeriesValue;

    private readonly Optional<ClickStackNumberChartSeries> _clickStackNumberChartSeriesValue;

    private readonly Optional<ClickStackSearchChartSeries> _clickStackSearchChartSeriesValue;

    private readonly Optional<ClickStackMarkdownChartSeries> _clickStackMarkdownChartSeriesValue;

    private ClickStackDashboardChartSeries(Optional<ClickStackTimeChartSeries> clickStackTimeChartSeriesValue,
        Optional<ClickStackTableChartSeries> clickStackTableChartSeriesValue,
        Optional<ClickStackNumberChartSeries> clickStackNumberChartSeriesValue,
        Optional<ClickStackSearchChartSeries> clickStackSearchChartSeriesValue,
        Optional<ClickStackMarkdownChartSeries> clickStackMarkdownChartSeriesValue)
    {
        _clickStackTimeChartSeriesValue = clickStackTimeChartSeriesValue;
        _clickStackTableChartSeriesValue = clickStackTableChartSeriesValue;
        _clickStackNumberChartSeriesValue = clickStackNumberChartSeriesValue;
        _clickStackSearchChartSeriesValue = clickStackSearchChartSeriesValue;
        _clickStackMarkdownChartSeriesValue = clickStackMarkdownChartSeriesValue;
    }

    public static ClickStackDashboardChartSeries ClickStackTimeChartSeries(ClickStackTimeChartSeries value) =>
        new(Optional<ClickStackTimeChartSeries>.Some(value), default, default, default, default);

    public static ClickStackDashboardChartSeries ClickStackTableChartSeries(ClickStackTableChartSeries value) =>
        new(default, Optional<ClickStackTableChartSeries>.Some(value), default, default, default);

    public static ClickStackDashboardChartSeries ClickStackNumberChartSeries(ClickStackNumberChartSeries value) =>
        new(default, default, Optional<ClickStackNumberChartSeries>.Some(value), default, default);

    public static ClickStackDashboardChartSeries ClickStackSearchChartSeries(ClickStackSearchChartSeries value) =>
        new(default, default, default, Optional<ClickStackSearchChartSeries>.Some(value), default);

    public static ClickStackDashboardChartSeries ClickStackMarkdownChartSeries(ClickStackMarkdownChartSeries value) =>
        new(default, default, default, default, Optional<ClickStackMarkdownChartSeries>.Some(value));

    public bool TryGetClickStackTimeChartSeries(out ClickStackTimeChartSeries value) =>
        _clickStackTimeChartSeriesValue.TryGetValue(out value);

    public bool TryGetClickStackTableChartSeries(out ClickStackTableChartSeries value) =>
        _clickStackTableChartSeriesValue.TryGetValue(out value);

    public bool TryGetClickStackNumberChartSeries(out ClickStackNumberChartSeries value) =>
        _clickStackNumberChartSeriesValue.TryGetValue(out value);

    public bool TryGetClickStackSearchChartSeries(out ClickStackSearchChartSeries value) =>
        _clickStackSearchChartSeriesValue.TryGetValue(out value);

    public bool TryGetClickStackMarkdownChartSeries(out ClickStackMarkdownChartSeries value) =>
        _clickStackMarkdownChartSeriesValue.TryGetValue(out value);

    public static implicit operator ClickStackDashboardChartSeries(ClickStackTimeChartSeries value) =>
        ClickStackTimeChartSeries(value);

    public static implicit operator ClickStackDashboardChartSeries(ClickStackTableChartSeries value) =>
        ClickStackTableChartSeries(value);

    public static implicit operator ClickStackDashboardChartSeries(ClickStackNumberChartSeries value) =>
        ClickStackNumberChartSeries(value);

    public static implicit operator ClickStackDashboardChartSeries(ClickStackSearchChartSeries value) =>
        ClickStackSearchChartSeries(value);

    public static implicit operator ClickStackDashboardChartSeries(ClickStackMarkdownChartSeries value) =>
        ClickStackMarkdownChartSeries(value);
}

file sealed class ClickStackDashboardChartSeriesConverter : JsonConverter<ClickStackDashboardChartSeries>
{
    public override ClickStackDashboardChartSeries Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackTimeChartSeries>(root,
            options,
            out var clickStackTimeChartSeriesValue))
        {
            return ClickStackDashboardChartSeries.ClickStackTimeChartSeries(clickStackTimeChartSeriesValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackTableChartSeries>(root,
            options,
            out var clickStackTableChartSeriesValue))
        {
            return ClickStackDashboardChartSeries.ClickStackTableChartSeries(clickStackTableChartSeriesValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackNumberChartSeries>(root,
            options,
            out var clickStackNumberChartSeriesValue))
        {
            return ClickStackDashboardChartSeries.ClickStackNumberChartSeries(clickStackNumberChartSeriesValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackSearchChartSeries>(root,
            options,
            out var clickStackSearchChartSeriesValue))
        {
            return ClickStackDashboardChartSeries.ClickStackSearchChartSeries(clickStackSearchChartSeriesValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackMarkdownChartSeries>(root,
            options,
            out var clickStackMarkdownChartSeriesValue))
        {
            return ClickStackDashboardChartSeries.ClickStackMarkdownChartSeries(clickStackMarkdownChartSeriesValue);
        }
        throw new JsonException($"JSON does not match ClickStackTimeChartSeries or ClickStackTableChartSeries or ClickStackNumberChartSeries or ClickStackSearchChartSeries or ClickStackMarkdownChartSeries schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackDashboardChartSeries value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackTimeChartSeries(out var clickStackTimeChartSeriesValue))
        {
            JsonSerializer.Serialize(writer, clickStackTimeChartSeriesValue, options);
        }
        else if (value.TryGetClickStackTableChartSeries(out var clickStackTableChartSeriesValue))
        {
            JsonSerializer.Serialize(writer, clickStackTableChartSeriesValue, options);
        }
        else if (value.TryGetClickStackNumberChartSeries(out var clickStackNumberChartSeriesValue))
        {
            JsonSerializer.Serialize(writer, clickStackNumberChartSeriesValue, options);
        }
        else if (value.TryGetClickStackSearchChartSeries(out var clickStackSearchChartSeriesValue))
        {
            JsonSerializer.Serialize(writer, clickStackSearchChartSeriesValue, options);
        }
        else if (value.TryGetClickStackMarkdownChartSeries(out var clickStackMarkdownChartSeriesValue))
        {
            JsonSerializer.Serialize(writer, clickStackMarkdownChartSeriesValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackDashboardChartSeries)} contains no valid value to serialize.");
        }
    }
}
