using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Fraction of a table's rows that must change before autovacuum runs ANALYZE to refresh planner statistics.
/// </summary>
[JsonConverter(typeof(AutovacuumAnalyzeScaleFactorConverter))]
public record AutovacuumAnalyzeScaleFactor
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<double> _doubleValue;

    private AutovacuumAnalyzeScaleFactor(Optional<string> stringValue, Optional<double> doubleValue)
    {
        _stringValue = stringValue;
        _doubleValue = doubleValue;
    }

    public static AutovacuumAnalyzeScaleFactor String(string value) =>
        new(Optional<string>.Some(value), default);

    public static AutovacuumAnalyzeScaleFactor Double(double value) =>
        new(default, Optional<double>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDouble(out double value) => _doubleValue.TryGetValue(out value);

    public static implicit operator AutovacuumAnalyzeScaleFactor(string value) => String(value);

    public static implicit operator AutovacuumAnalyzeScaleFactor(double value) => Double(value);
}

file sealed class AutovacuumAnalyzeScaleFactorConverter : JsonConverter<AutovacuumAnalyzeScaleFactor>
{
    public override AutovacuumAnalyzeScaleFactor Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AutovacuumAnalyzeScaleFactor.String(value);
        }
        if (JsonSerializer.TryDeserialize<double>(root, options, out var doubleValue))
        {
            return AutovacuumAnalyzeScaleFactor.Double(doubleValue);
        }
        throw new JsonException($"JSON does not match string or double schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        AutovacuumAnalyzeScaleFactor value,
        JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetDouble(out var doubleValue))
        {
            JsonSerializer.Serialize(writer, doubleValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AutovacuumAnalyzeScaleFactor)} contains no valid value to serialize.");
        }
    }
}
