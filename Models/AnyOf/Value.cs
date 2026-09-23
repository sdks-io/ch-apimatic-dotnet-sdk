using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// A finite number, or a string up to 200 characters, to compare for equality.
/// </summary>
[JsonConverter(typeof(ValueConverter))]
public record Value
{
    private readonly Optional<double> _doubleValue;

    private readonly Optional<string> _stringValue;

    private Value(Optional<double> doubleValue, Optional<string> stringValue)
    {
        _doubleValue = doubleValue;
        _stringValue = stringValue;
    }

    public static Value Double(double value) => new(Optional<double>.Some(value), default);

    public static Value String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetDouble(out double value) => _doubleValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Value(double value) => Double(value);

    public static implicit operator Value(string value) => String(value);
}

file sealed class ValueConverter : JsonConverter<Value>
{
    public override Value Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<double>(root, options, out var doubleValue))
        {
            return Value.Double(doubleValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Value.String(value);
        }
        throw new JsonException($"JSON does not match double or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Value value, JsonSerializerOptions options)
    {
        if (value.TryGetDouble(out var doubleValue))
        {
            JsonSerializer.Serialize(writer, doubleValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Value)} contains no valid value to serialize.");
        }
    }
}
