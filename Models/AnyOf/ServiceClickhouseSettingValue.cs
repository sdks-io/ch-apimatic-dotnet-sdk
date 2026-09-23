using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Setting value in its native JSON type. Use the settings schema endpoint for per-setting constraints.
/// </summary>
[JsonConverter(typeof(ServiceClickhouseSettingValueConverter))]
public record ServiceClickhouseSettingValue
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private ServiceClickhouseSettingValue(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static ServiceClickhouseSettingValue String(string value) =>
        new(Optional<string>.Some(value), default);

    public static ServiceClickhouseSettingValue Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator ServiceClickhouseSettingValue(string value) => String(value);

    public static implicit operator ServiceClickhouseSettingValue(int value) => Int(value);
}

file sealed class ServiceClickhouseSettingValueConverter : JsonConverter<ServiceClickhouseSettingValue>
{
    public override ServiceClickhouseSettingValue Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ServiceClickhouseSettingValue.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return ServiceClickhouseSettingValue.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ServiceClickhouseSettingValue value,
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
            throw new JsonException($"{nameof(ServiceClickhouseSettingValue)} contains no valid value to serialize.");
        }
    }
}
