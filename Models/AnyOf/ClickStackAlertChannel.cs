using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackAlertChannelConverter))]
public record ClickStackAlertChannel
{
    private readonly Optional<ClickStackAlertChannelEmail> _clickStackAlertChannelEmailValue;

    private readonly Optional<ClickStackAlertChannelWebhook> _clickStackAlertChannelWebhookValue;

    private ClickStackAlertChannel(Optional<ClickStackAlertChannelEmail> clickStackAlertChannelEmailValue,
        Optional<ClickStackAlertChannelWebhook> clickStackAlertChannelWebhookValue)
    {
        _clickStackAlertChannelEmailValue = clickStackAlertChannelEmailValue;
        _clickStackAlertChannelWebhookValue = clickStackAlertChannelWebhookValue;
    }

    public static ClickStackAlertChannel ClickStackAlertChannelEmail(ClickStackAlertChannelEmail value) =>
        new(Optional<ClickStackAlertChannelEmail>.Some(value), default);

    public static ClickStackAlertChannel ClickStackAlertChannelWebhook(ClickStackAlertChannelWebhook value) =>
        new(default, Optional<ClickStackAlertChannelWebhook>.Some(value));

    public bool TryGetClickStackAlertChannelEmail(out ClickStackAlertChannelEmail value) =>
        _clickStackAlertChannelEmailValue.TryGetValue(out value);

    public bool TryGetClickStackAlertChannelWebhook(out ClickStackAlertChannelWebhook value) =>
        _clickStackAlertChannelWebhookValue.TryGetValue(out value);

    public static implicit operator ClickStackAlertChannel(ClickStackAlertChannelEmail value) =>
        ClickStackAlertChannelEmail(value);

    public static implicit operator ClickStackAlertChannel(ClickStackAlertChannelWebhook value) =>
        ClickStackAlertChannelWebhook(value);
}

file sealed class ClickStackAlertChannelConverter : JsonConverter<ClickStackAlertChannel>
{
    public override ClickStackAlertChannel Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackAlertChannelEmail>(root,
            options,
            out var clickStackAlertChannelEmailValue))
        {
            return ClickStackAlertChannel.ClickStackAlertChannelEmail(clickStackAlertChannelEmailValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackAlertChannelWebhook>(root,
            options,
            out var clickStackAlertChannelWebhookValue))
        {
            return ClickStackAlertChannel.ClickStackAlertChannelWebhook(clickStackAlertChannelWebhookValue);
        }
        throw new JsonException($"JSON does not match ClickStackAlertChannelEmail or ClickStackAlertChannelWebhook schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackAlertChannel value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackAlertChannelEmail(out var clickStackAlertChannelEmailValue))
        {
            JsonSerializer.Serialize(writer, clickStackAlertChannelEmailValue, options);
        }
        else if (value.TryGetClickStackAlertChannelWebhook(out var clickStackAlertChannelWebhookValue))
        {
            JsonSerializer.Serialize(writer, clickStackAlertChannelWebhookValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackAlertChannel)} contains no valid value to serialize.");
        }
    }
}
