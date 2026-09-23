using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Minimum size of past WAL files kept in pg_wal for standby servers. Use 0 to disable.
/// </summary>
[JsonConverter(typeof(WalKeepSizeConverter))]
public record WalKeepSize
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private WalKeepSize(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static WalKeepSize String(string value) => new(Optional<string>.Some(value), default);

    public static WalKeepSize Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator WalKeepSize(string value) => String(value);

    public static implicit operator WalKeepSize(int value) => Int(value);
}

file sealed class WalKeepSizeConverter : JsonConverter<WalKeepSize>
{
    public override WalKeepSize Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return WalKeepSize.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue) && intValue.MeetsMinimum(0))
            {
                return WalKeepSize.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, WalKeepSize value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(WalKeepSize)} contains no valid value to serialize.");
        }
    }
}
