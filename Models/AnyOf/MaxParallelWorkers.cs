using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Maximum number of workers that can be used for parallel operations. Cannot exceed max_worker_processes.
/// </summary>
[JsonConverter(typeof(MaxParallelWorkersConverter))]
public record MaxParallelWorkers
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private MaxParallelWorkers(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static MaxParallelWorkers String(string value) => new(Optional<string>.Some(value), default);

    public static MaxParallelWorkers Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator MaxParallelWorkers(string value) => String(value);

    public static implicit operator MaxParallelWorkers(int value) => Int(value);
}

file sealed class MaxParallelWorkersConverter : JsonConverter<MaxParallelWorkers>
{
    public override MaxParallelWorkers Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MaxParallelWorkers.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(0))
            {
                return MaxParallelWorkers.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, MaxParallelWorkers value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(MaxParallelWorkers)} contains no valid value to serialize.");
        }
    }
}
