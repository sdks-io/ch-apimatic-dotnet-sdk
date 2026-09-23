using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(MaxCommandExecutionTimeConverter))]
public record MaxCommandExecutionTime
{
    private readonly Optional<int> _intValue;

    private MaxCommandExecutionTime(Optional<int> intValue)
    {
        _intValue = intValue;
    }

    public static MaxCommandExecutionTime Int(int value) => new(Optional<int>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator MaxCommandExecutionTime(int value) => Int(value);
}

file sealed class MaxCommandExecutionTimeConverter : JsonConverter<MaxCommandExecutionTime>
{
    public override MaxCommandExecutionTime Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(1))
            {
                return MaxCommandExecutionTime.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MaxCommandExecutionTime value, JsonSerializerOptions options)
    {
        if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(MaxCommandExecutionTime)} contains no valid value to serialize.");
        }
    }
}
