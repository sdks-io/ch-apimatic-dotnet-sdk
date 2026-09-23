using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Maximum size WAL can grow between checkpoints. Larger values improve write performance but increase crash recovery time.
/// </summary>
[JsonConverter(typeof(MaxWalSizeConverter))]
public record MaxWalSize
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private MaxWalSize(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static MaxWalSize String(string value) => new(Optional<string>.Some(value), default);

    public static MaxWalSize Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator MaxWalSize(string value) => String(value);

    public static implicit operator MaxWalSize(int value) => Int(value);
}

file sealed class MaxWalSizeConverter : JsonConverter<MaxWalSize>
{
    public override MaxWalSize Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MaxWalSize.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(32768))
            {
                return MaxWalSize.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MaxWalSize value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(MaxWalSize)} contains no valid value to serialize.");
        }
    }
}
