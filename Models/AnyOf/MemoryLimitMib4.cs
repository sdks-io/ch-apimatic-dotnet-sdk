using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Maximum memory, in MiB, available to each UDF sandbox process. Null uses the sandbox default.
/// </summary>
[JsonConverter(typeof(MemoryLimitMib4Converter))]
public record MemoryLimitMib4
{
    private readonly Optional<int> _intValue;

    private MemoryLimitMib4(Optional<int> intValue)
    {
        _intValue = intValue;
    }

    public static MemoryLimitMib4 Int(int value) => new(Optional<int>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator MemoryLimitMib4(int value) => Int(value);
}

file sealed class MemoryLimitMib4Converter : JsonConverter<MemoryLimitMib4>
{
    public override MemoryLimitMib4 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(1) &&
                intValue.MeetsMaximum(1048576))
            {
                return MemoryLimitMib4.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MemoryLimitMib4 value, JsonSerializerOptions options)
    {
        if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MemoryLimitMib4)} contains no valid value to serialize.");
        }
    }
}
