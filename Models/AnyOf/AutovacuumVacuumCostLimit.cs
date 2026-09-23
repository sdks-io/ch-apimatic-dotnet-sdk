using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Cost-accounting limit shared across all autovacuum workers before they pause. Use -1 to inherit vacuum_cost_limit.
/// </summary>
[JsonConverter(typeof(AutovacuumVacuumCostLimitConverter))]
public record AutovacuumVacuumCostLimit
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private AutovacuumVacuumCostLimit(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static AutovacuumVacuumCostLimit String(string value) =>
        new(Optional<string>.Some(value), default);

    public static AutovacuumVacuumCostLimit Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator AutovacuumVacuumCostLimit(string value) => String(value);

    public static implicit operator AutovacuumVacuumCostLimit(int value) => Int(value);
}

file sealed class AutovacuumVacuumCostLimitConverter : JsonConverter<AutovacuumVacuumCostLimit>
{
    public override AutovacuumVacuumCostLimit Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AutovacuumVacuumCostLimit.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(1))
            {
                return AutovacuumVacuumCostLimit.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AutovacuumVacuumCostLimit value,
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
            throw new JsonException($"{nameof(AutovacuumVacuumCostLimit)} contains no valid value to serialize.");
        }
    }
}
