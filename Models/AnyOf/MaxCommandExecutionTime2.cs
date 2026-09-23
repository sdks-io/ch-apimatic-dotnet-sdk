using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Maximum command execution time in seconds for executable_pool UDFs.
/// </summary>
[JsonConverter(typeof(MaxCommandExecutionTime2Converter))]
public record MaxCommandExecutionTime2
{
    private readonly Optional<int> _intValue;

    private MaxCommandExecutionTime2(Optional<int> intValue)
    {
        _intValue = intValue;
    }

    public static MaxCommandExecutionTime2 Int(int value) => new(Optional<int>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator MaxCommandExecutionTime2(int value) => Int(value);
}

file sealed class MaxCommandExecutionTime2Converter : JsonConverter<MaxCommandExecutionTime2>
{
    public override MaxCommandExecutionTime2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(1))
            {
                return MaxCommandExecutionTime2.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MaxCommandExecutionTime2 value, JsonSerializerOptions options)
    {
        if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MaxCommandExecutionTime2)} contains no valid value to serialize.");
        }
    }
}
