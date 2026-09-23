using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Minimum delay between autovacuum runs. Lower values make autovacuum check for work more frequently.
/// </summary>
[JsonConverter(typeof(AutovacuumNaptimeConverter))]
public record AutovacuumNaptime
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private AutovacuumNaptime(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static AutovacuumNaptime String(string value) => new(Optional<string>.Some(value), default);

    public static AutovacuumNaptime Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator AutovacuumNaptime(string value) => String(value);

    public static implicit operator AutovacuumNaptime(int value) => Int(value);
}

file sealed class AutovacuumNaptimeConverter : JsonConverter<AutovacuumNaptime>
{
    public override AutovacuumNaptime Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AutovacuumNaptime.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(1))
            {
                return AutovacuumNaptime.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AutovacuumNaptime value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(AutovacuumNaptime)} contains no valid value to serialize.");
        }
    }
}
