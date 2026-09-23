using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(UdfVersionCreateRequest2Converter))]
public record UdfVersionCreateRequest2
{
    private readonly Optional<UdfVersionCreateRequest> _udfVersionCreateRequestValue;

    private readonly Optional<UdfVersionCreateRequest1> _udfVersionCreateRequest1Value;

    private UdfVersionCreateRequest2(Optional<UdfVersionCreateRequest> udfVersionCreateRequestValue,
        Optional<UdfVersionCreateRequest1> udfVersionCreateRequest1Value)
    {
        _udfVersionCreateRequestValue = udfVersionCreateRequestValue;
        _udfVersionCreateRequest1Value = udfVersionCreateRequest1Value;
    }

    public static UdfVersionCreateRequest2 UdfVersionCreateRequest(UdfVersionCreateRequest value) =>
        new(Optional<UdfVersionCreateRequest>.Some(value), default);

    public static UdfVersionCreateRequest2 UdfVersionCreateRequest1(UdfVersionCreateRequest1 value) =>
        new(default, Optional<UdfVersionCreateRequest1>.Some(value));

    public bool TryGetUdfVersionCreateRequest(out UdfVersionCreateRequest value) =>
        _udfVersionCreateRequestValue.TryGetValue(out value);

    public bool TryGetUdfVersionCreateRequest1(out UdfVersionCreateRequest1 value) =>
        _udfVersionCreateRequest1Value.TryGetValue(out value);

    public static implicit operator UdfVersionCreateRequest2(UdfVersionCreateRequest value) =>
        UdfVersionCreateRequest(value);

    public static implicit operator UdfVersionCreateRequest2(UdfVersionCreateRequest1 value) =>
        UdfVersionCreateRequest1(value);
}

file sealed class UdfVersionCreateRequest2Converter : JsonConverter<UdfVersionCreateRequest2>
{
    public override UdfVersionCreateRequest2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<UdfVersionCreateRequest>(root,
            options,
            out var udfVersionCreateRequestValue))
        {
            return UdfVersionCreateRequest2.UdfVersionCreateRequest(udfVersionCreateRequestValue);
        }
        if (JsonSerializer.TryDeserialize<UdfVersionCreateRequest1>(root,
            options,
            out var udfVersionCreateRequest1Value))
        {
            return UdfVersionCreateRequest2.UdfVersionCreateRequest1(udfVersionCreateRequest1Value);
        }
        throw new JsonException($"JSON does not match UdfVersionCreateRequest or UdfVersionCreateRequest1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, UdfVersionCreateRequest2 value, JsonSerializerOptions options)
    {
        if (value.TryGetUdfVersionCreateRequest(out var udfVersionCreateRequestValue))
        {
            JsonSerializer.Serialize(writer, udfVersionCreateRequestValue, options);
        }
        else if (value.TryGetUdfVersionCreateRequest1(out var udfVersionCreateRequest1Value))
        {
            JsonSerializer.Serialize(writer, udfVersionCreateRequest1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(UdfVersionCreateRequest2)} contains no valid value to serialize.");
        }
    }
}
