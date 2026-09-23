using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Terminate any statement that takes more than the specified time, even while active. Use 0 to disable.
/// </summary>
[JsonConverter(typeof(TransactionTimeoutConverter))]
public record TransactionTimeout
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private TransactionTimeout(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static TransactionTimeout String(string value) => new(Optional<string>.Some(value), default);

    public static TransactionTimeout Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator TransactionTimeout(string value) => String(value);

    public static implicit operator TransactionTimeout(int value) => Int(value);
}

file sealed class TransactionTimeoutConverter : JsonConverter<TransactionTimeout>
{
    public override TransactionTimeout Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TransactionTimeout.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(0))
            {
                return TransactionTimeout.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TransactionTimeout value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TransactionTimeout)} contains no valid value to serialize.");
        }
    }
}
