using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Number of concurrent disk I/O operations the planner expects. Higher values (100-200) benefit SSDs.
/// </summary>
[JsonConverter(typeof(EffectiveIoConcurrencyConverter))]
public record EffectiveIoConcurrency
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private EffectiveIoConcurrency(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static EffectiveIoConcurrency String(string value) => new(Optional<string>.Some(value), default);

    public static EffectiveIoConcurrency Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator EffectiveIoConcurrency(string value) => String(value);

    public static implicit operator EffectiveIoConcurrency(int value) => Int(value);
}

file sealed class EffectiveIoConcurrencyConverter : JsonConverter<EffectiveIoConcurrency>
{
    public override EffectiveIoConcurrency Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EffectiveIoConcurrency.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(0))
            {
                return EffectiveIoConcurrency.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EffectiveIoConcurrency value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EffectiveIoConcurrency)} contains no valid value to serialize.");
        }
    }
}
