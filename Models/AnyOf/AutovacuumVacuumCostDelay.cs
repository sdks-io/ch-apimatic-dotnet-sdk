using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Time autovacuum sleeps when the cost limit is reached. Lower values speed up vacuuming at the cost of more I/O.
/// </summary>
[JsonConverter(typeof(AutovacuumVacuumCostDelayConverter))]
public record AutovacuumVacuumCostDelay
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private AutovacuumVacuumCostDelay(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static AutovacuumVacuumCostDelay String(string value) =>
        new(Optional<string>.Some(value), default);

    public static AutovacuumVacuumCostDelay Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator AutovacuumVacuumCostDelay(string value) => String(value);

    public static implicit operator AutovacuumVacuumCostDelay(int value) => Int(value);
}

file sealed class AutovacuumVacuumCostDelayConverter : JsonConverter<AutovacuumVacuumCostDelay>
{
    public override AutovacuumVacuumCostDelay Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AutovacuumVacuumCostDelay.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(0))
            {
                return AutovacuumVacuumCostDelay.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AutovacuumVacuumCostDelay value,
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
            throw new JsonException($"{nameof(AutovacuumVacuumCostDelay)} contains no valid value to serialize.");
        }
    }
}
