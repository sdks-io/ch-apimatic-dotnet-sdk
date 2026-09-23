using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickPipeMutateBigQuerySourceConverter))]
public record ClickPipeMutateBigQuerySource
{
    private readonly Optional<ClickPipePostBigQueryServiceAccountSource> _clickPipePostBigQueryServiceAccountSourceValue;

    private readonly Optional<ClickPipePostBigQueryWorkloadIdentitySource> _clickPipePostBigQueryWorkloadIdentitySourceValue;

    private ClickPipeMutateBigQuerySource(Optional<ClickPipePostBigQueryServiceAccountSource> clickPipePostBigQueryServiceAccountSourceValue,
        Optional<ClickPipePostBigQueryWorkloadIdentitySource> clickPipePostBigQueryWorkloadIdentitySourceValue)
    {
        _clickPipePostBigQueryServiceAccountSourceValue = clickPipePostBigQueryServiceAccountSourceValue;
        _clickPipePostBigQueryWorkloadIdentitySourceValue = clickPipePostBigQueryWorkloadIdentitySourceValue;
    }

    public static ClickPipeMutateBigQuerySource ClickPipePostBigQueryServiceAccountSource(ClickPipePostBigQueryServiceAccountSource value) =>
        new(Optional<ClickPipePostBigQueryServiceAccountSource>.Some(value), default);

    public static ClickPipeMutateBigQuerySource ClickPipePostBigQueryWorkloadIdentitySource(ClickPipePostBigQueryWorkloadIdentitySource value) =>
        new(default, Optional<ClickPipePostBigQueryWorkloadIdentitySource>.Some(value));

    public bool TryGetClickPipePostBigQueryServiceAccountSource(out ClickPipePostBigQueryServiceAccountSource value) =>
        _clickPipePostBigQueryServiceAccountSourceValue.TryGetValue(out value);

    public bool TryGetClickPipePostBigQueryWorkloadIdentitySource(out ClickPipePostBigQueryWorkloadIdentitySource value) =>
        _clickPipePostBigQueryWorkloadIdentitySourceValue.TryGetValue(out value);

    public static implicit operator ClickPipeMutateBigQuerySource(ClickPipePostBigQueryServiceAccountSource value) =>
        ClickPipePostBigQueryServiceAccountSource(value);

    public static implicit operator ClickPipeMutateBigQuerySource(ClickPipePostBigQueryWorkloadIdentitySource value) =>
        ClickPipePostBigQueryWorkloadIdentitySource(value);
}

file sealed class ClickPipeMutateBigQuerySourceConverter : JsonConverter<ClickPipeMutateBigQuerySource>
{
    public override ClickPipeMutateBigQuerySource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickPipePostBigQueryServiceAccountSource>(root,
            options,
            out var clickPipePostBigQueryServiceAccountSourceValue))
        {
            return ClickPipeMutateBigQuerySource.ClickPipePostBigQueryServiceAccountSource(clickPipePostBigQueryServiceAccountSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickPipePostBigQueryWorkloadIdentitySource>(root,
            options,
            out var clickPipePostBigQueryWorkloadIdentitySourceValue))
        {
            return ClickPipeMutateBigQuerySource.ClickPipePostBigQueryWorkloadIdentitySource(clickPipePostBigQueryWorkloadIdentitySourceValue);
        }
        throw new JsonException($"JSON does not match ClickPipePostBigQueryServiceAccountSource or ClickPipePostBigQueryWorkloadIdentitySource schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickPipeMutateBigQuerySource value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickPipePostBigQueryServiceAccountSource(out var clickPipePostBigQueryServiceAccountSourceValue))
        {
            JsonSerializer.Serialize(writer, clickPipePostBigQueryServiceAccountSourceValue, options);
        }
        else if (value.TryGetClickPipePostBigQueryWorkloadIdentitySource(out var clickPipePostBigQueryWorkloadIdentitySourceValue))
        {
            JsonSerializer.Serialize(writer, clickPipePostBigQueryWorkloadIdentitySourceValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickPipeMutateBigQuerySource)} contains no valid value to serialize.");
        }
    }
}
