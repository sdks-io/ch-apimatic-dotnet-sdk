using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickPipeBigQuerySourceConverter))]
public record ClickPipeBigQuerySource
{
    private readonly Optional<ClickPipeBigQueryServiceAccountSource> _clickPipeBigQueryServiceAccountSourceValue;

    private readonly Optional<ClickPipeBigQueryWorkloadIdentitySource> _clickPipeBigQueryWorkloadIdentitySourceValue;

    private ClickPipeBigQuerySource(Optional<ClickPipeBigQueryServiceAccountSource> clickPipeBigQueryServiceAccountSourceValue,
        Optional<ClickPipeBigQueryWorkloadIdentitySource> clickPipeBigQueryWorkloadIdentitySourceValue)
    {
        _clickPipeBigQueryServiceAccountSourceValue = clickPipeBigQueryServiceAccountSourceValue;
        _clickPipeBigQueryWorkloadIdentitySourceValue = clickPipeBigQueryWorkloadIdentitySourceValue;
    }

    public static ClickPipeBigQuerySource ClickPipeBigQueryServiceAccountSource(ClickPipeBigQueryServiceAccountSource value) =>
        new(Optional<ClickPipeBigQueryServiceAccountSource>.Some(value), default);

    public static ClickPipeBigQuerySource ClickPipeBigQueryWorkloadIdentitySource(ClickPipeBigQueryWorkloadIdentitySource value) =>
        new(default, Optional<ClickPipeBigQueryWorkloadIdentitySource>.Some(value));

    public bool TryGetClickPipeBigQueryServiceAccountSource(out ClickPipeBigQueryServiceAccountSource value) =>
        _clickPipeBigQueryServiceAccountSourceValue.TryGetValue(out value);

    public bool TryGetClickPipeBigQueryWorkloadIdentitySource(out ClickPipeBigQueryWorkloadIdentitySource value) =>
        _clickPipeBigQueryWorkloadIdentitySourceValue.TryGetValue(out value);

    public static implicit operator ClickPipeBigQuerySource(ClickPipeBigQueryServiceAccountSource value) =>
        ClickPipeBigQueryServiceAccountSource(value);

    public static implicit operator ClickPipeBigQuerySource(ClickPipeBigQueryWorkloadIdentitySource value) =>
        ClickPipeBigQueryWorkloadIdentitySource(value);
}

file sealed class ClickPipeBigQuerySourceConverter : JsonConverter<ClickPipeBigQuerySource>
{
    public override ClickPipeBigQuerySource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickPipeBigQueryServiceAccountSource>(root,
            options,
            out var clickPipeBigQueryServiceAccountSourceValue))
        {
            return ClickPipeBigQuerySource.ClickPipeBigQueryServiceAccountSource(clickPipeBigQueryServiceAccountSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickPipeBigQueryWorkloadIdentitySource>(root,
            options,
            out var clickPipeBigQueryWorkloadIdentitySourceValue))
        {
            return ClickPipeBigQuerySource.ClickPipeBigQueryWorkloadIdentitySource(clickPipeBigQueryWorkloadIdentitySourceValue);
        }
        throw new JsonException($"JSON does not match ClickPipeBigQueryServiceAccountSource or ClickPipeBigQueryWorkloadIdentitySource schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ClickPipeBigQuerySource value, JsonSerializerOptions options)
    {
        if (value.TryGetClickPipeBigQueryServiceAccountSource(out var clickPipeBigQueryServiceAccountSourceValue))
        {
            JsonSerializer.Serialize(writer, clickPipeBigQueryServiceAccountSourceValue, options);
        }
        else if (value.TryGetClickPipeBigQueryWorkloadIdentitySource(out var clickPipeBigQueryWorkloadIdentitySourceValue))
        {
            JsonSerializer.Serialize(writer, clickPipeBigQueryWorkloadIdentitySourceValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickPipeBigQuerySource)} contains no valid value to serialize.");
        }
    }
}
