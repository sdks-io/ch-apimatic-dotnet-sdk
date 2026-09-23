using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Cursor for the current page. Null for the first page.
/// </summary>
[JsonConverter(typeof(CurrentCursorConverter))]
public record CurrentCursor
{
    private readonly Optional<string> _stringValue;

    private CurrentCursor(Optional<string> stringValue)
    {
        _stringValue = stringValue;
    }

    public static CurrentCursor String(string value) => new(Optional<string>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator CurrentCursor(string value) => String(value);
}

file sealed class CurrentCursorConverter : JsonConverter<CurrentCursor>
{
    public override CurrentCursor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return CurrentCursor.String(value);
        }
        throw new JsonException($"JSON does not match string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CurrentCursor value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CurrentCursor)} contains no valid value to serialize.");
        }
    }
}
