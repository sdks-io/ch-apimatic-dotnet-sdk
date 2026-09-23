using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackOnClickTargetConverter))]
public record ClickStackOnClickTarget
{
    private readonly Optional<ClickStackOnClickTargetIdVariant> _clickStackOnClickTargetIdVariantValue;

    private readonly Optional<ClickStackOnClickTargetTemplateVariant> _clickStackOnClickTargetTemplateVariantValue;

    private ClickStackOnClickTarget(Optional<ClickStackOnClickTargetIdVariant> clickStackOnClickTargetIdVariantValue,
        Optional<ClickStackOnClickTargetTemplateVariant> clickStackOnClickTargetTemplateVariantValue)
    {
        _clickStackOnClickTargetIdVariantValue = clickStackOnClickTargetIdVariantValue;
        _clickStackOnClickTargetTemplateVariantValue = clickStackOnClickTargetTemplateVariantValue;
    }

    public static ClickStackOnClickTarget ClickStackOnClickTargetIdVariant(ClickStackOnClickTargetIdVariant value) =>
        new(Optional<ClickStackOnClickTargetIdVariant>.Some(value), default);

    public static ClickStackOnClickTarget ClickStackOnClickTargetTemplateVariant(ClickStackOnClickTargetTemplateVariant value) =>
        new(default, Optional<ClickStackOnClickTargetTemplateVariant>.Some(value));

    public bool TryGetClickStackOnClickTargetIdVariant(out ClickStackOnClickTargetIdVariant value) =>
        _clickStackOnClickTargetIdVariantValue.TryGetValue(out value);

    public bool TryGetClickStackOnClickTargetTemplateVariant(out ClickStackOnClickTargetTemplateVariant value) =>
        _clickStackOnClickTargetTemplateVariantValue.TryGetValue(out value);

    public static implicit operator ClickStackOnClickTarget(ClickStackOnClickTargetIdVariant value) =>
        ClickStackOnClickTargetIdVariant(value);

    public static implicit operator ClickStackOnClickTarget(ClickStackOnClickTargetTemplateVariant value) =>
        ClickStackOnClickTargetTemplateVariant(value);
}

file sealed class ClickStackOnClickTargetConverter : JsonConverter<ClickStackOnClickTarget>
{
    public override ClickStackOnClickTarget Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackOnClickTargetIdVariant>(root,
            options,
            out var clickStackOnClickTargetIdVariantValue))
        {
            return ClickStackOnClickTarget.ClickStackOnClickTargetIdVariant(clickStackOnClickTargetIdVariantValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackOnClickTargetTemplateVariant>(root,
            options,
            out var clickStackOnClickTargetTemplateVariantValue))
        {
            return ClickStackOnClickTarget.ClickStackOnClickTargetTemplateVariant(clickStackOnClickTargetTemplateVariantValue);
        }
        throw new JsonException($"JSON does not match ClickStackOnClickTargetIdVariant or ClickStackOnClickTargetTemplateVariant schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickStackOnClickTarget value, JsonSerializerOptions options)
    {
        if (value.TryGetClickStackOnClickTargetIdVariant(out var clickStackOnClickTargetIdVariantValue))
        {
            JsonSerializer.Serialize(writer, clickStackOnClickTargetIdVariantValue, options);
        }
        else if (value.TryGetClickStackOnClickTargetTemplateVariant(out var clickStackOnClickTargetTemplateVariantValue))
        {
            JsonSerializer.Serialize(writer, clickStackOnClickTargetTemplateVariantValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackOnClickTarget)} contains no valid value to serialize.");
        }
    }
}
