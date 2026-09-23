using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(UdfCreateRequest2Converter))]
public record UdfCreateRequest2
{
    private readonly Optional<UdfCreateRequest> _udfCreateRequestValue;

    private readonly Optional<UdfCreateRequest1> _udfCreateRequest1Value;

    private UdfCreateRequest2(Optional<UdfCreateRequest> udfCreateRequestValue,
        Optional<UdfCreateRequest1> udfCreateRequest1Value)
    {
        _udfCreateRequestValue = udfCreateRequestValue;
        _udfCreateRequest1Value = udfCreateRequest1Value;
    }

    public static UdfCreateRequest2 UdfCreateRequest(UdfCreateRequest value) =>
        new(Optional<UdfCreateRequest>.Some(value), default);

    public static UdfCreateRequest2 UdfCreateRequest1(UdfCreateRequest1 value) =>
        new(default, Optional<UdfCreateRequest1>.Some(value));

    public bool TryGetUdfCreateRequest(out UdfCreateRequest value) =>
        _udfCreateRequestValue.TryGetValue(out value);

    public bool TryGetUdfCreateRequest1(out UdfCreateRequest1 value) =>
        _udfCreateRequest1Value.TryGetValue(out value);

    public static implicit operator UdfCreateRequest2(UdfCreateRequest value) => UdfCreateRequest(value);

    public static implicit operator UdfCreateRequest2(UdfCreateRequest1 value) => UdfCreateRequest1(value);
}

file sealed class UdfCreateRequest2Converter : JsonConverter<UdfCreateRequest2>
{
    public override UdfCreateRequest2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<UdfCreateRequest>(root, options, out var udfCreateRequestValue))
        {
            return UdfCreateRequest2.UdfCreateRequest(udfCreateRequestValue);
        }
        if (JsonSerializer.TryDeserialize<UdfCreateRequest1>(root, options, out var udfCreateRequest1Value))
        {
            return UdfCreateRequest2.UdfCreateRequest1(udfCreateRequest1Value);
        }
        throw new JsonException($"JSON does not match UdfCreateRequest or UdfCreateRequest1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, UdfCreateRequest2 value, JsonSerializerOptions options)
    {
        if (value.TryGetUdfCreateRequest(out var udfCreateRequestValue))
        {
            JsonSerializer.Serialize(writer, udfCreateRequestValue, options);
        }
        else if (value.TryGetUdfCreateRequest1(out var udfCreateRequest1Value))
        {
            JsonSerializer.Serialize(writer, udfCreateRequest1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(UdfCreateRequest2)} contains no valid value to serialize.");
        }
    }
}
