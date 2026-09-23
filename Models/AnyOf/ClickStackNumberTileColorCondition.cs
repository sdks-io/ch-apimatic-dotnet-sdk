using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackNumberTileColorConditionConverter))]
public record ClickStackNumberTileColorCondition
{
    private readonly Optional<ClickStackNumericColorCondition> _clickStackNumericColorConditionValue;

    private readonly Optional<ClickStackBetweenColorCondition> _clickStackBetweenColorConditionValue;

    private readonly Optional<ClickStackEqualityColorCondition> _clickStackEqualityColorConditionValue;

    private ClickStackNumberTileColorCondition(Optional<ClickStackNumericColorCondition> clickStackNumericColorConditionValue,
        Optional<ClickStackBetweenColorCondition> clickStackBetweenColorConditionValue,
        Optional<ClickStackEqualityColorCondition> clickStackEqualityColorConditionValue)
    {
        _clickStackNumericColorConditionValue = clickStackNumericColorConditionValue;
        _clickStackBetweenColorConditionValue = clickStackBetweenColorConditionValue;
        _clickStackEqualityColorConditionValue = clickStackEqualityColorConditionValue;
    }

    public static ClickStackNumberTileColorCondition ClickStackNumericColorCondition(ClickStackNumericColorCondition value) =>
        new(Optional<ClickStackNumericColorCondition>.Some(value), default, default);

    public static ClickStackNumberTileColorCondition ClickStackBetweenColorCondition(ClickStackBetweenColorCondition value) =>
        new(default, Optional<ClickStackBetweenColorCondition>.Some(value), default);

    public static ClickStackNumberTileColorCondition ClickStackEqualityColorCondition(ClickStackEqualityColorCondition value) =>
        new(default, default, Optional<ClickStackEqualityColorCondition>.Some(value));

    public bool TryGetClickStackNumericColorCondition(out ClickStackNumericColorCondition value) =>
        _clickStackNumericColorConditionValue.TryGetValue(out value);

    public bool TryGetClickStackBetweenColorCondition(out ClickStackBetweenColorCondition value) =>
        _clickStackBetweenColorConditionValue.TryGetValue(out value);

    public bool TryGetClickStackEqualityColorCondition(out ClickStackEqualityColorCondition value) =>
        _clickStackEqualityColorConditionValue.TryGetValue(out value);

    public static implicit operator ClickStackNumberTileColorCondition(ClickStackNumericColorCondition value) =>
        ClickStackNumericColorCondition(value);

    public static implicit operator ClickStackNumberTileColorCondition(ClickStackBetweenColorCondition value) =>
        ClickStackBetweenColorCondition(value);

    public static implicit operator ClickStackNumberTileColorCondition(ClickStackEqualityColorCondition value) =>
        ClickStackEqualityColorCondition(value);
}

file sealed class ClickStackNumberTileColorConditionConverter : JsonConverter<ClickStackNumberTileColorCondition>
{
    public override ClickStackNumberTileColorCondition Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackNumericColorCondition>(root,
            options,
            out var clickStackNumericColorConditionValue))
        {
            return ClickStackNumberTileColorCondition.ClickStackNumericColorCondition(clickStackNumericColorConditionValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackBetweenColorCondition>(root,
            options,
            out var clickStackBetweenColorConditionValue))
        {
            return ClickStackNumberTileColorCondition.ClickStackBetweenColorCondition(clickStackBetweenColorConditionValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackEqualityColorCondition>(root,
            options,
            out var clickStackEqualityColorConditionValue))
        {
            return ClickStackNumberTileColorCondition.ClickStackEqualityColorCondition(clickStackEqualityColorConditionValue);
        }
        throw new JsonException($"JSON does not match ClickStackNumericColorCondition or ClickStackBetweenColorCondition or ClickStackEqualityColorCondition schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackNumberTileColorCondition value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackNumericColorCondition(out var clickStackNumericColorConditionValue))
        {
            JsonSerializer.Serialize(writer, clickStackNumericColorConditionValue, options);
        }
        else if (value.TryGetClickStackBetweenColorCondition(out var clickStackBetweenColorConditionValue))
        {
            JsonSerializer.Serialize(writer, clickStackBetweenColorConditionValue, options);
        }
        else if (value.TryGetClickStackEqualityColorCondition(out var clickStackEqualityColorConditionValue))
        {
            JsonSerializer.Serialize(writer, clickStackEqualityColorConditionValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackNumberTileColorCondition)} contains no valid value to serialize.");
        }
    }
}
