using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Command pool size for executable_pool UDFs.
/// </summary>
[JsonConverter(typeof(PoolSizeConverter))]
public record PoolSize
{
    private readonly Optional<int> _intValue;

    private PoolSize(Optional<int> intValue)
    {
        _intValue = intValue;
    }

    public static PoolSize Int(int value) => new(Optional<int>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator PoolSize(int value) => Int(value);
}

file sealed class PoolSizeConverter : JsonConverter<PoolSize>
{
    public override PoolSize Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(1))
            {
                return PoolSize.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PoolSize value, JsonSerializerOptions options)
    {
        if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PoolSize)} contains no valid value to serialize.");
        }
    }
}
