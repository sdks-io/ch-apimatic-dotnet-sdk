using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Maximum number of parallel workers for maintenance operations like CREATE INDEX and VACUUM.
/// </summary>
[JsonConverter(typeof(MaxParallelMaintenanceWorkersConverter))]
public record MaxParallelMaintenanceWorkers
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private MaxParallelMaintenanceWorkers(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static MaxParallelMaintenanceWorkers String(string value) =>
        new(Optional<string>.Some(value), default);

    public static MaxParallelMaintenanceWorkers Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator MaxParallelMaintenanceWorkers(string value) => String(value);

    public static implicit operator MaxParallelMaintenanceWorkers(int value) => Int(value);
}

file sealed class MaxParallelMaintenanceWorkersConverter : JsonConverter<MaxParallelMaintenanceWorkers>
{
    public override MaxParallelMaintenanceWorkers Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return MaxParallelMaintenanceWorkers.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(0))
            {
                return MaxParallelMaintenanceWorkers.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        MaxParallelMaintenanceWorkers value,
        JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(MaxParallelMaintenanceWorkers)} contains no valid value to serialize.");
        }
    }
}
