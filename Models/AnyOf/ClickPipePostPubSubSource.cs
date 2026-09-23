using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(ClickPipePostPubSubSourceConverter))]
public record ClickPipePostPubSubSource
{
    private readonly Optional<ClickPipePostPubSubServiceAccountSource> _clickPipePostPubSubServiceAccountSourceValue;

    private readonly Optional<ClickPipePostPubSubWorkloadIdentitySource> _clickPipePostPubSubWorkloadIdentitySourceValue;

    private ClickPipePostPubSubSource(Optional<ClickPipePostPubSubServiceAccountSource> clickPipePostPubSubServiceAccountSourceValue,
        Optional<ClickPipePostPubSubWorkloadIdentitySource> clickPipePostPubSubWorkloadIdentitySourceValue)
    {
        _clickPipePostPubSubServiceAccountSourceValue = clickPipePostPubSubServiceAccountSourceValue;
        _clickPipePostPubSubWorkloadIdentitySourceValue = clickPipePostPubSubWorkloadIdentitySourceValue;
    }

    public static ClickPipePostPubSubSource ClickPipePostPubSubServiceAccountSource(ClickPipePostPubSubServiceAccountSource value) =>
        new(Optional<ClickPipePostPubSubServiceAccountSource>.Some(value), default);

    public static ClickPipePostPubSubSource ClickPipePostPubSubWorkloadIdentitySource(ClickPipePostPubSubWorkloadIdentitySource value) =>
        new(default, Optional<ClickPipePostPubSubWorkloadIdentitySource>.Some(value));

    public bool TryGetClickPipePostPubSubServiceAccountSource(out ClickPipePostPubSubServiceAccountSource value) =>
        _clickPipePostPubSubServiceAccountSourceValue.TryGetValue(out value);

    public bool TryGetClickPipePostPubSubWorkloadIdentitySource(out ClickPipePostPubSubWorkloadIdentitySource value) =>
        _clickPipePostPubSubWorkloadIdentitySourceValue.TryGetValue(out value);

    public static implicit operator ClickPipePostPubSubSource(ClickPipePostPubSubServiceAccountSource value) =>
        ClickPipePostPubSubServiceAccountSource(value);

    public static implicit operator ClickPipePostPubSubSource(ClickPipePostPubSubWorkloadIdentitySource value) =>
        ClickPipePostPubSubWorkloadIdentitySource(value);
}

file sealed class ClickPipePostPubSubSourceConverter : JsonConverter<ClickPipePostPubSubSource>
{
    public override ClickPipePostPubSubSource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ClickPipePostPubSubServiceAccountSource>(root,
            options,
            out var clickPipePostPubSubServiceAccountSourceValue))
        {
            return ClickPipePostPubSubSource.ClickPipePostPubSubServiceAccountSource(clickPipePostPubSubServiceAccountSourceValue);
        }
        if (JsonSerializer.TryDeserialize<ClickPipePostPubSubWorkloadIdentitySource>(root,
            options,
            out var clickPipePostPubSubWorkloadIdentitySourceValue))
        {
            return ClickPipePostPubSubSource.ClickPipePostPubSubWorkloadIdentitySource(clickPipePostPubSubWorkloadIdentitySourceValue);
        }
        throw new JsonException($"JSON does not match ClickPipePostPubSubServiceAccountSource or ClickPipePostPubSubWorkloadIdentitySource schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        ClickPipePostPubSubSource value,
        JsonSerializerOptions options)
    {
        if (value.TryGetClickPipePostPubSubServiceAccountSource(out var clickPipePostPubSubServiceAccountSourceValue))
        {
            JsonSerializer.Serialize(writer, clickPipePostPubSubServiceAccountSourceValue, options);
        }
        else if (value.TryGetClickPipePostPubSubWorkloadIdentitySource(out var clickPipePostPubSubWorkloadIdentitySourceValue))
        {
            JsonSerializer.Serialize(writer, clickPipePostPubSubWorkloadIdentitySourceValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ClickPipePostPubSubSource)} contains no valid value to serialize.");
        }
    }
}
