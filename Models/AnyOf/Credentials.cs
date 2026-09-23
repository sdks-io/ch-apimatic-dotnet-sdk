using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

/// <summary>
/// Credentials for Kafka source. Choose one that is supported by the authentication method.
/// </summary>
[JsonConverter(typeof(CredentialsConverter))]
public record Credentials
{
    private readonly Optional<Plain> _plainValue;

    private readonly Optional<MskIamUser> _mskIamUserValue;

    private readonly Optional<AzureEventHub> _azureEventHubValue;

    private readonly Optional<MutualTls> _mutualTlsValue;

    private Credentials(Optional<Plain> plainValue,
        Optional<MskIamUser> mskIamUserValue,
        Optional<AzureEventHub> azureEventHubValue,
        Optional<MutualTls> mutualTlsValue)
    {
        _plainValue = plainValue;
        _mskIamUserValue = mskIamUserValue;
        _azureEventHubValue = azureEventHubValue;
        _mutualTlsValue = mutualTlsValue;
    }

    public static Credentials Plain(Plain value) =>
        new(Optional<Plain>.Some(value), default, default, default);

    public static Credentials MskIamUser(MskIamUser value) =>
        new(default, Optional<MskIamUser>.Some(value), default, default);

    public static Credentials AzureEventHub(AzureEventHub value) =>
        new(default, default, Optional<AzureEventHub>.Some(value), default);

    public static Credentials MutualTls(MutualTls value) =>
        new(default, default, default, Optional<MutualTls>.Some(value));

    public bool TryGetPlain(out Plain value) => _plainValue.TryGetValue(out value);

    public bool TryGetMskIamUser(out MskIamUser value) => _mskIamUserValue.TryGetValue(out value);

    public bool TryGetAzureEventHub(out AzureEventHub value) => _azureEventHubValue.TryGetValue(out value);

    public bool TryGetMutualTls(out MutualTls value) => _mutualTlsValue.TryGetValue(out value);

    public static implicit operator Credentials(Plain value) => Plain(value);

    public static implicit operator Credentials(MskIamUser value) => MskIamUser(value);

    public static implicit operator Credentials(AzureEventHub value) => AzureEventHub(value);

    public static implicit operator Credentials(MutualTls value) => MutualTls(value);
}

file sealed class CredentialsConverter : JsonConverter<Credentials>
{
    public override Credentials Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Plain>(root, options, out var plainValue))
        {
            return Credentials.Plain(plainValue);
        }
        if (JsonSerializer.TryDeserialize<MskIamUser>(root, options, out var mskIamUserValue))
        {
            return Credentials.MskIamUser(mskIamUserValue);
        }
        if (JsonSerializer.TryDeserialize<AzureEventHub>(root, options, out var azureEventHubValue))
        {
            return Credentials.AzureEventHub(azureEventHubValue);
        }
        if (JsonSerializer.TryDeserialize<MutualTls>(root, options, out var mutualTlsValue))
        {
            return Credentials.MutualTls(mutualTlsValue);
        }
        throw new JsonException($"JSON does not match Plain or MskIamUser or AzureEventHub or MutualTls schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Credentials value, JsonSerializerOptions options)
    {
        if (value.TryGetPlain(out var plainValue))
        {
            JsonSerializer.Serialize(writer, plainValue, options);
        }
        else if (value.TryGetMskIamUser(out var mskIamUserValue))
        {
            JsonSerializer.Serialize(writer, mskIamUserValue, options);
        }
        else if (value.TryGetAzureEventHub(out var azureEventHubValue))
        {
            JsonSerializer.Serialize(writer, azureEventHubValue, options);
        }
        else if (value.TryGetMutualTls(out var mutualTlsValue))
        {
            JsonSerializer.Serialize(writer, mutualTlsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Credentials)} contains no valid value to serialize.");
        }
    }
}
