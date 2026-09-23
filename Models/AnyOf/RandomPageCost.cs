using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Sets the planner's estimate of the cost of a non-sequentially-fetched disk page. Lower values (1.1-1.5) are better for SSDs.
/// </summary>
[JsonConverter(typeof(RandomPageCostConverter))]
public record RandomPageCost
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<double> _doubleValue;

    private RandomPageCost(Optional<string> stringValue, Optional<double> doubleValue)
    {
        _stringValue = stringValue;
        _doubleValue = doubleValue;
    }

    public static RandomPageCost String(string value) => new(Optional<string>.Some(value), default);

    public static RandomPageCost Double(double value) => new(default, Optional<double>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetDouble(out double value) => _doubleValue.TryGetValue(out value);

    public static implicit operator RandomPageCost(string value) => String(value);

    public static implicit operator RandomPageCost(double value) => Double(value);
}

file sealed class RandomPageCostConverter : JsonConverter<RandomPageCost>
{
    public override RandomPageCost Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return RandomPageCost.String(value);
        }
        if (JsonSerializer.TryDeserialize<double>(root, options, out var doubleValue))
        {
            return RandomPageCost.Double(doubleValue);
        }
        throw new JsonException($"JSON does not match string or double schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, RandomPageCost value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(RandomPageCost)} contains no valid value to serialize.");
        }
    }
}
