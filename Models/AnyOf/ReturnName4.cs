using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Name of the returned value, or null when unnamed.
/// </summary>
[JsonConverter(typeof(ReturnName4Converter))]
public record ReturnName4
{
    private readonly Optional<string> _stringValue;

    private ReturnName4(Optional<string> stringValue)
    {
        _stringValue = stringValue;
    }

    public static ReturnName4 String(string value) => new(Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator ReturnName4(string value) => String(value);
}

file sealed class ReturnName4Converter : JsonConverter<ReturnName4>
{
    public override ReturnName4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ReturnName4.String(value);
        }
        throw new JsonException($"JSON does not match string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReturnName4 value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ReturnName4)} contains no valid value to serialize.");
        }
    }
}
