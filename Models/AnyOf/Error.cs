using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Build error, or null when no build error is present.
/// </summary>
[JsonConverter(typeof(ErrorConverter))]
public record Error
{
    private readonly Optional<string> _stringValue;

    private Error(Optional<string> stringValue)
    {
        _stringValue = stringValue;
    }

    public static Error String(string value) => new(Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Error(string value) => String(value);
}

file sealed class ErrorConverter : JsonConverter<Error>
{
    public override Error Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Error.String(value);
        }
        throw new JsonException($"JSON does not match string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Error value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Error)} contains no valid value to serialize.");
        }
    }
}
