using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackSourceConverter))]
public record ClickStackSource
{
    private readonly Optional<ClickStackLogSource> _clickStackLogSourceValue;

    private readonly Optional<ClickStackTraceSource> _clickStackTraceSourceValue;

    private readonly Optional<ClickStackMetricSource> _clickStackMetricSourceValue;

    private readonly Optional<ClickStackSessionSource> _clickStackSessionSourceValue;

    private readonly Optional<ClickStackPromqlSource> _clickStackPromqlSourceValue;

    private ClickStackSource(Optional<ClickStackLogSource> clickStackLogSourceValue,
        Optional<ClickStackTraceSource> clickStackTraceSourceValue,
        Optional<ClickStackMetricSource> clickStackMetricSourceValue,
        Optional<ClickStackSessionSource> clickStackSessionSourceValue,
        Optional<ClickStackPromqlSource> clickStackPromqlSourceValue)
    {
        _clickStackLogSourceValue = clickStackLogSourceValue;
        _clickStackTraceSourceValue = clickStackTraceSourceValue;
        _clickStackMetricSourceValue = clickStackMetricSourceValue;
        _clickStackSessionSourceValue = clickStackSessionSourceValue;
        _clickStackPromqlSourceValue = clickStackPromqlSourceValue;
    }

    public static ClickStackSource ClickStackLogSource(ClickStackLogSource value) =>
        new(Optional<ClickStackLogSource>.Some(value), default, default, default, default);

    public static ClickStackSource ClickStackTraceSource(ClickStackTraceSource value) =>
        new(default, Optional<ClickStackTraceSource>.Some(value), default, default, default);

    public static ClickStackSource ClickStackMetricSource(ClickStackMetricSource value) =>
        new(default, default, Optional<ClickStackMetricSource>.Some(value), default, default);

    public static ClickStackSource ClickStackSessionSource(ClickStackSessionSource value) =>
        new(default, default, default, Optional<ClickStackSessionSource>.Some(value), default);

    public static ClickStackSource ClickStackPromqlSource(ClickStackPromqlSource value) =>
        new(default, default, default, default, Optional<ClickStackPromqlSource>.Some(value));

    public bool TryGetClickStackLogSource(out ClickStackLogSource value) =>
        _clickStackLogSourceValue.TryGetValue(out value);

    public bool TryGetClickStackTraceSource(out ClickStackTraceSource value) =>
        _clickStackTraceSourceValue.TryGetValue(out value);

    public bool TryGetClickStackMetricSource(out ClickStackMetricSource value) =>
        _clickStackMetricSourceValue.TryGetValue(out value);

    public bool TryGetClickStackSessionSource(out ClickStackSessionSource value) =>
        _clickStackSessionSourceValue.TryGetValue(out value);

    public bool TryGetClickStackPromqlSource(out ClickStackPromqlSource value) =>
        _clickStackPromqlSourceValue.TryGetValue(out value);

    public static implicit operator ClickStackSource(ClickStackLogSource value) => ClickStackLogSource(value);

    public static implicit operator ClickStackSource(ClickStackTraceSource value) =>
        ClickStackTraceSource(value);

    public static implicit operator ClickStackSource(ClickStackMetricSource value) =>
        ClickStackMetricSource(value);

    public static implicit operator ClickStackSource(ClickStackSessionSource value) =>
        ClickStackSessionSource(value);

    public static implicit operator ClickStackSource(ClickStackPromqlSource value) =>
        ClickStackPromqlSource(value);
}

file sealed class ClickStackSourceConverter : JsonConverter<ClickStackSource>
{
    public override ClickStackSource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackLogSource>(root, options, out var clickStackLogSourceValue))
        {
            return ClickStackSource.ClickStackLogSource(clickStackLogSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackTraceSource>(root, options, out var clickStackTraceSourceValue))
        {
            return ClickStackSource.ClickStackTraceSource(clickStackTraceSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackMetricSource>(root,
            options,
            out var clickStackMetricSourceValue))
        {
            return ClickStackSource.ClickStackMetricSource(clickStackMetricSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackSessionSource>(root,
            options,
            out var clickStackSessionSourceValue))
        {
            return ClickStackSource.ClickStackSessionSource(clickStackSessionSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackPromqlSource>(root,
            options,
            out var clickStackPromqlSourceValue))
        {
            return ClickStackSource.ClickStackPromqlSource(clickStackPromqlSourceValue);
        }
        throw new JsonException($"JSON does not match ClickStackLogSource or ClickStackTraceSource or ClickStackMetricSource or ClickStackSessionSource or ClickStackPromqlSource schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackSource value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackLogSource(out var clickStackLogSourceValue))
        {
            JsonSerializer.Serialize(writer, clickStackLogSourceValue, options);
        }
        else if (value.TryGetClickStackTraceSource(out var clickStackTraceSourceValue))
        {
            JsonSerializer.Serialize(writer, clickStackTraceSourceValue, options);
        }
        else if (value.TryGetClickStackMetricSource(out var clickStackMetricSourceValue))
        {
            JsonSerializer.Serialize(writer, clickStackMetricSourceValue, options);
        }
        else if (value.TryGetClickStackSessionSource(out var clickStackSessionSourceValue))
        {
            JsonSerializer.Serialize(writer, clickStackSessionSourceValue, options);
        }
        else if (value.TryGetClickStackPromqlSource(out var clickStackPromqlSourceValue))
        {
            JsonSerializer.Serialize(writer, clickStackPromqlSourceValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackSource)} contains no valid value to serialize.");
        }
    }
}
