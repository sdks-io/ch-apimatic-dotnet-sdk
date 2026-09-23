using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ReturnNameConverter))]
public record ReturnName
{
    private readonly Optional<string> _stringValue;

    private ReturnName(Optional<string> stringValue)
    {
        _stringValue = stringValue;
    }

    public static ReturnName String(string value) => new(Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator ReturnName(string value) => String(value);
}

file sealed class ReturnNameConverter : JsonConverter<ReturnName>
{
    public override ReturnName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            if (value.MatchesPattern("^[A-Za-z][A-Za-z0-9_]*$"))
            {
                return ReturnName.String(value);
            }
        }
        throw new JsonException($"JSON does not match string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ReturnName value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ReturnName)} contains no valid value to serialize.");
        }
    }
}
