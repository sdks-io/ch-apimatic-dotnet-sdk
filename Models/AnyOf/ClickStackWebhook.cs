using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackWebhookConverter))]
public record ClickStackWebhook
{
    private readonly Optional<ClickStackSlackWebhook> _clickStackSlackWebhookValue;

    private readonly Optional<ClickStackIncidentIoWebhook> _clickStackIncidentIoWebhookValue;

    private readonly Optional<ClickStackGenericWebhook> _clickStackGenericWebhookValue;

    private readonly Optional<ClickStackSlackApiWebhook> _clickStackSlackApiWebhookValue;

    private readonly Optional<ClickStackPagerDutyApiWebhook> _clickStackPagerDutyApiWebhookValue;

    private ClickStackWebhook(Optional<ClickStackSlackWebhook> clickStackSlackWebhookValue,
        Optional<ClickStackIncidentIoWebhook> clickStackIncidentIoWebhookValue,
        Optional<ClickStackGenericWebhook> clickStackGenericWebhookValue,
        Optional<ClickStackSlackApiWebhook> clickStackSlackApiWebhookValue,
        Optional<ClickStackPagerDutyApiWebhook> clickStackPagerDutyApiWebhookValue)
    {
        _clickStackSlackWebhookValue = clickStackSlackWebhookValue;
        _clickStackIncidentIoWebhookValue = clickStackIncidentIoWebhookValue;
        _clickStackGenericWebhookValue = clickStackGenericWebhookValue;
        _clickStackSlackApiWebhookValue = clickStackSlackApiWebhookValue;
        _clickStackPagerDutyApiWebhookValue = clickStackPagerDutyApiWebhookValue;
    }

    public static ClickStackWebhook ClickStackSlackWebhook(ClickStackSlackWebhook value) =>
        new(Optional<ClickStackSlackWebhook>.Some(value), default, default, default, default);

    public static ClickStackWebhook ClickStackIncidentIoWebhook(ClickStackIncidentIoWebhook value) =>
        new(default, Optional<ClickStackIncidentIoWebhook>.Some(value), default, default, default);

    public static ClickStackWebhook ClickStackGenericWebhook(ClickStackGenericWebhook value) =>
        new(default, default, Optional<ClickStackGenericWebhook>.Some(value), default, default);

    public static ClickStackWebhook ClickStackSlackApiWebhook(ClickStackSlackApiWebhook value) =>
        new(default, default, default, Optional<ClickStackSlackApiWebhook>.Some(value), default);

    public static ClickStackWebhook ClickStackPagerDutyApiWebhook(ClickStackPagerDutyApiWebhook value) =>
        new(default, default, default, default, Optional<ClickStackPagerDutyApiWebhook>.Some(value));

    public bool TryGetClickStackSlackWebhook(out ClickStackSlackWebhook value) =>
        _clickStackSlackWebhookValue.TryGetValue(out value);

    public bool TryGetClickStackIncidentIoWebhook(out ClickStackIncidentIoWebhook value) =>
        _clickStackIncidentIoWebhookValue.TryGetValue(out value);

    public bool TryGetClickStackGenericWebhook(out ClickStackGenericWebhook value) =>
        _clickStackGenericWebhookValue.TryGetValue(out value);

    public bool TryGetClickStackSlackApiWebhook(out ClickStackSlackApiWebhook value) =>
        _clickStackSlackApiWebhookValue.TryGetValue(out value);

    public bool TryGetClickStackPagerDutyApiWebhook(out ClickStackPagerDutyApiWebhook value) =>
        _clickStackPagerDutyApiWebhookValue.TryGetValue(out value);

    public static implicit operator ClickStackWebhook(ClickStackSlackWebhook value) =>
        ClickStackSlackWebhook(value);

    public static implicit operator ClickStackWebhook(ClickStackIncidentIoWebhook value) =>
        ClickStackIncidentIoWebhook(value);

    public static implicit operator ClickStackWebhook(ClickStackGenericWebhook value) =>
        ClickStackGenericWebhook(value);

    public static implicit operator ClickStackWebhook(ClickStackSlackApiWebhook value) =>
        ClickStackSlackApiWebhook(value);

    public static implicit operator ClickStackWebhook(ClickStackPagerDutyApiWebhook value) =>
        ClickStackPagerDutyApiWebhook(value);
}

file sealed class ClickStackWebhookConverter : JsonConverter<ClickStackWebhook>
{
    public override ClickStackWebhook Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackSlackWebhook>(root,
            options,
            out var clickStackSlackWebhookValue))
        {
            return ClickStackWebhook.ClickStackSlackWebhook(clickStackSlackWebhookValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackIncidentIoWebhook>(root,
            options,
            out var clickStackIncidentIoWebhookValue))
        {
            return ClickStackWebhook.ClickStackIncidentIoWebhook(clickStackIncidentIoWebhookValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackGenericWebhook>(root,
            options,
            out var clickStackGenericWebhookValue))
        {
            return ClickStackWebhook.ClickStackGenericWebhook(clickStackGenericWebhookValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackSlackApiWebhook>(root,
            options,
            out var clickStackSlackApiWebhookValue))
        {
            return ClickStackWebhook.ClickStackSlackApiWebhook(clickStackSlackApiWebhookValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackPagerDutyApiWebhook>(root,
            options,
            out var clickStackPagerDutyApiWebhookValue))
        {
            return ClickStackWebhook.ClickStackPagerDutyApiWebhook(clickStackPagerDutyApiWebhookValue);
        }
        throw new JsonException($"JSON does not match ClickStackSlackWebhook or ClickStackIncidentIoWebhook or ClickStackGenericWebhook or ClickStackSlackApiWebhook or ClickStackPagerDutyApiWebhook schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackWebhook value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackSlackWebhook(out var clickStackSlackWebhookValue))
        {
            JsonSerializer.Serialize(writer, clickStackSlackWebhookValue, options);
        }
        else if (value.TryGetClickStackIncidentIoWebhook(out var clickStackIncidentIoWebhookValue))
        {
            JsonSerializer.Serialize(writer, clickStackIncidentIoWebhookValue, options);
        }
        else if (value.TryGetClickStackGenericWebhook(out var clickStackGenericWebhookValue))
        {
            JsonSerializer.Serialize(writer, clickStackGenericWebhookValue, options);
        }
        else if (value.TryGetClickStackSlackApiWebhook(out var clickStackSlackApiWebhookValue))
        {
            JsonSerializer.Serialize(writer, clickStackSlackApiWebhookValue, options);
        }
        else if (value.TryGetClickStackPagerDutyApiWebhook(out var clickStackPagerDutyApiWebhookValue))
        {
            JsonSerializer.Serialize(writer, clickStackPagerDutyApiWebhookValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackWebhook)} contains no valid value to serialize.");
        }
    }
}
