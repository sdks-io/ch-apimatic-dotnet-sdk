using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickStackSavedFilterValueConverter))]
public record ClickStackSavedFilterValue
{
    private readonly Optional<ClickStackSqlSavedFilterValue> _clickStackSqlSavedFilterValueValue;

    private readonly Optional<ClickStackVariableSavedFilterValue> _clickStackVariableSavedFilterValueValue;

    private ClickStackSavedFilterValue(Optional<ClickStackSqlSavedFilterValue> clickStackSqlSavedFilterValueValue,
        Optional<ClickStackVariableSavedFilterValue> clickStackVariableSavedFilterValueValue)
    {
        _clickStackSqlSavedFilterValueValue = clickStackSqlSavedFilterValueValue;
        _clickStackVariableSavedFilterValueValue = clickStackVariableSavedFilterValueValue;
    }

    public static ClickStackSavedFilterValue ClickStackSqlSavedFilterValue(ClickStackSqlSavedFilterValue value) =>
        new(Optional<ClickStackSqlSavedFilterValue>.Some(value), default);

    public static ClickStackSavedFilterValue ClickStackVariableSavedFilterValue(ClickStackVariableSavedFilterValue value) =>
        new(default, Optional<ClickStackVariableSavedFilterValue>.Some(value));

    public bool TryGetClickStackSqlSavedFilterValue(out ClickStackSqlSavedFilterValue value) =>
        _clickStackSqlSavedFilterValueValue.TryGetValue(out value);

    public bool TryGetClickStackVariableSavedFilterValue(out ClickStackVariableSavedFilterValue value) =>
        _clickStackVariableSavedFilterValueValue.TryGetValue(out value);

    public static implicit operator ClickStackSavedFilterValue(ClickStackSqlSavedFilterValue value) =>
        ClickStackSqlSavedFilterValue(value);

    public static implicit operator ClickStackSavedFilterValue(ClickStackVariableSavedFilterValue value) =>
        ClickStackVariableSavedFilterValue(value);
}

file sealed class ClickStackSavedFilterValueConverter : JsonConverter<ClickStackSavedFilterValue>
{
    public override ClickStackSavedFilterValue Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickStackSqlSavedFilterValue>(root,
            options,
            out var clickStackSqlSavedFilterValueValue))
        {
            return ClickStackSavedFilterValue.ClickStackSqlSavedFilterValue(clickStackSqlSavedFilterValueValue);
        }
        if (JsonSerializer.TryDeserialize<ClickStackVariableSavedFilterValue>(root,
            options,
            out var clickStackVariableSavedFilterValueValue))
        {
            return ClickStackSavedFilterValue.ClickStackVariableSavedFilterValue(clickStackVariableSavedFilterValueValue);
        }
        throw new JsonException($"JSON does not match ClickStackSqlSavedFilterValue or ClickStackVariableSavedFilterValue schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickStackSavedFilterValue value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickStackSqlSavedFilterValue(out var clickStackSqlSavedFilterValueValue))
        {
            JsonSerializer.Serialize(writer, clickStackSqlSavedFilterValueValue, options);
        }
        else if (value.TryGetClickStackVariableSavedFilterValue(out var clickStackVariableSavedFilterValueValue))
        {
            JsonSerializer.Serialize(writer, clickStackVariableSavedFilterValueValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickStackSavedFilterValue)} contains no valid value to serialize.");
        }
    }
}
