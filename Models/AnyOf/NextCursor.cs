using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Cursor for the next page. Null if there are no more results.
/// </summary>
[JsonConverter(typeof(NextCursorConverter))]
public record NextCursor
{
    private readonly Optional<string> _stringValue;

    private NextCursor(Optional<string> stringValue)
    {
        _stringValue = stringValue;
    }

    public static NextCursor String(string value) => new(Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator NextCursor(string value) => String(value);
}

file sealed class NextCursorConverter : JsonConverter<NextCursor>
{
    public override NextCursor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return NextCursor.String(value);
        }
        throw new JsonException($"JSON does not match string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, NextCursor value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(NextCursor)} contains no valid value to serialize.");
        }
    }
}
