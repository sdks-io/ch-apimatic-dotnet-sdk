using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(BackupBucketPostRequestConverter))]
public record BackupBucketPostRequest
{
    private readonly Optional<AwsBackupBucketPostRequestV1> _awsBackupBucketPostRequestV1Value;

    private readonly Optional<GcpBackupBucketPostRequestV1> _gcpBackupBucketPostRequestV1Value;

    private readonly Optional<AzureBackupBucketPostRequestV1> _azureBackupBucketPostRequestV1Value;

    private BackupBucketPostRequest(Optional<AwsBackupBucketPostRequestV1> awsBackupBucketPostRequestV1Value,
        Optional<GcpBackupBucketPostRequestV1> gcpBackupBucketPostRequestV1Value,
        Optional<AzureBackupBucketPostRequestV1> azureBackupBucketPostRequestV1Value)
    {
        _awsBackupBucketPostRequestV1Value = awsBackupBucketPostRequestV1Value;
        _gcpBackupBucketPostRequestV1Value = gcpBackupBucketPostRequestV1Value;
        _azureBackupBucketPostRequestV1Value = azureBackupBucketPostRequestV1Value;
    }

    public static BackupBucketPostRequest AwsBackupBucketPostRequestV1(AwsBackupBucketPostRequestV1 value) =>
        new(Optional<AwsBackupBucketPostRequestV1>.Some(value), default, default);

    public static BackupBucketPostRequest GcpBackupBucketPostRequestV1(GcpBackupBucketPostRequestV1 value) =>
        new(default, Optional<GcpBackupBucketPostRequestV1>.Some(value), default);

    public static BackupBucketPostRequest AzureBackupBucketPostRequestV1(AzureBackupBucketPostRequestV1 value) =>
        new(default, default, Optional<AzureBackupBucketPostRequestV1>.Some(value));

    public bool TryGetAwsBackupBucketPostRequestV1(out AwsBackupBucketPostRequestV1 value) =>
        _awsBackupBucketPostRequestV1Value.TryGetValue(out value);

    public bool TryGetGcpBackupBucketPostRequestV1(out GcpBackupBucketPostRequestV1 value) =>
        _gcpBackupBucketPostRequestV1Value.TryGetValue(out value);

    public bool TryGetAzureBackupBucketPostRequestV1(out AzureBackupBucketPostRequestV1 value) =>
        _azureBackupBucketPostRequestV1Value.TryGetValue(out value);

    public static implicit operator BackupBucketPostRequest(AwsBackupBucketPostRequestV1 value) =>
        AwsBackupBucketPostRequestV1(value);

    public static implicit operator BackupBucketPostRequest(GcpBackupBucketPostRequestV1 value) =>
        GcpBackupBucketPostRequestV1(value);

    public static implicit operator BackupBucketPostRequest(AzureBackupBucketPostRequestV1 value) =>
        AzureBackupBucketPostRequestV1(value);
}

file sealed class BackupBucketPostRequestConverter : JsonConverter<BackupBucketPostRequest>
{
    public override BackupBucketPostRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AwsBackupBucketPostRequestV1>(root,
            options,
            out var awsBackupBucketPostRequestV1Value))
        {
            return BackupBucketPostRequest.AwsBackupBucketPostRequestV1(awsBackupBucketPostRequestV1Value);
        }
        if (JsonSerializer.TryDeserialize<GcpBackupBucketPostRequestV1>(root,
            options,
            out var gcpBackupBucketPostRequestV1Value))
        {
            return BackupBucketPostRequest.GcpBackupBucketPostRequestV1(gcpBackupBucketPostRequestV1Value);
        }
        if (JsonSerializer.TryDeserialize<AzureBackupBucketPostRequestV1>(root,
            options,
            out var azureBackupBucketPostRequestV1Value))
        {
            return BackupBucketPostRequest.AzureBackupBucketPostRequestV1(azureBackupBucketPostRequestV1Value);
        }
        throw new JsonException($"JSON does not match AwsBackupBucketPostRequestV1 or GcpBackupBucketPostRequestV1 or AzureBackupBucketPostRequestV1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, BackupBucketPostRequest value, JsonSerializerOptions options)
    {
        if (value.TryGetAwsBackupBucketPostRequestV1(out var awsBackupBucketPostRequestV1Value))
        {
            JsonSerializer.Serialize(writer, awsBackupBucketPostRequestV1Value, options);
        }
        else if (value.TryGetGcpBackupBucketPostRequestV1(out var gcpBackupBucketPostRequestV1Value))
        {
            JsonSerializer.Serialize(writer, gcpBackupBucketPostRequestV1Value, options);
        }
        else if (value.TryGetAzureBackupBucketPostRequestV1(out var azureBackupBucketPostRequestV1Value))
        {
            JsonSerializer.Serialize(writer, azureBackupBucketPostRequestV1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(BackupBucketPostRequest)} contains no valid value to serialize.");
        }
    }
}
