using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(BackupBucketPatchRequestConverter))]
public record BackupBucketPatchRequest
{
    private readonly Optional<AwsBackupBucketPatchRequestV1> _awsBackupBucketPatchRequestV1Value;

    private readonly Optional<GcpBackupBucketPatchRequestV1> _gcpBackupBucketPatchRequestV1Value;

    private readonly Optional<AzureBackupBucketPatchRequestV1> _azureBackupBucketPatchRequestV1Value;

    private BackupBucketPatchRequest(Optional<AwsBackupBucketPatchRequestV1> awsBackupBucketPatchRequestV1Value,
        Optional<GcpBackupBucketPatchRequestV1> gcpBackupBucketPatchRequestV1Value,
        Optional<AzureBackupBucketPatchRequestV1> azureBackupBucketPatchRequestV1Value)
    {
        _awsBackupBucketPatchRequestV1Value = awsBackupBucketPatchRequestV1Value;
        _gcpBackupBucketPatchRequestV1Value = gcpBackupBucketPatchRequestV1Value;
        _azureBackupBucketPatchRequestV1Value = azureBackupBucketPatchRequestV1Value;
    }

    public static BackupBucketPatchRequest AwsBackupBucketPatchRequestV1(AwsBackupBucketPatchRequestV1 value) =>
        new(Optional<AwsBackupBucketPatchRequestV1>.Some(value), default, default);

    public static BackupBucketPatchRequest GcpBackupBucketPatchRequestV1(GcpBackupBucketPatchRequestV1 value) =>
        new(default, Optional<GcpBackupBucketPatchRequestV1>.Some(value), default);

    public static BackupBucketPatchRequest AzureBackupBucketPatchRequestV1(AzureBackupBucketPatchRequestV1 value) =>
        new(default, default, Optional<AzureBackupBucketPatchRequestV1>.Some(value));

    public bool TryGetAwsBackupBucketPatchRequestV1(out AwsBackupBucketPatchRequestV1 value) =>
        _awsBackupBucketPatchRequestV1Value.TryGetValue(out value);

    public bool TryGetGcpBackupBucketPatchRequestV1(out GcpBackupBucketPatchRequestV1 value) =>
        _gcpBackupBucketPatchRequestV1Value.TryGetValue(out value);

    public bool TryGetAzureBackupBucketPatchRequestV1(out AzureBackupBucketPatchRequestV1 value) =>
        _azureBackupBucketPatchRequestV1Value.TryGetValue(out value);

    public static implicit operator BackupBucketPatchRequest(AwsBackupBucketPatchRequestV1 value) =>
        AwsBackupBucketPatchRequestV1(value);

    public static implicit operator BackupBucketPatchRequest(GcpBackupBucketPatchRequestV1 value) =>
        GcpBackupBucketPatchRequestV1(value);

    public static implicit operator BackupBucketPatchRequest(AzureBackupBucketPatchRequestV1 value) =>
        AzureBackupBucketPatchRequestV1(value);
}

file sealed class BackupBucketPatchRequestConverter : JsonConverter<BackupBucketPatchRequest>
{
    public override BackupBucketPatchRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AwsBackupBucketPatchRequestV1>(root,
            options,
            out var awsBackupBucketPatchRequestV1Value))
        {
            return BackupBucketPatchRequest.AwsBackupBucketPatchRequestV1(awsBackupBucketPatchRequestV1Value);
        }
        if (JsonSerializer.TryDeserialize<GcpBackupBucketPatchRequestV1>(root,
            options,
            out var gcpBackupBucketPatchRequestV1Value))
        {
            return BackupBucketPatchRequest.GcpBackupBucketPatchRequestV1(gcpBackupBucketPatchRequestV1Value);
        }
        if (JsonSerializer.TryDeserialize<AzureBackupBucketPatchRequestV1>(root,
            options,
            out var azureBackupBucketPatchRequestV1Value))
        {
            return BackupBucketPatchRequest.AzureBackupBucketPatchRequestV1(azureBackupBucketPatchRequestV1Value);
        }
        throw new JsonException($"JSON does not match AwsBackupBucketPatchRequestV1 or GcpBackupBucketPatchRequestV1 or AzureBackupBucketPatchRequestV1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, BackupBucketPatchRequest value, JsonSerializerOptions options)
    {
        if (value.TryGetAwsBackupBucketPatchRequestV1(out var awsBackupBucketPatchRequestV1Value))
        {
            JsonSerializer.Serialize(writer, awsBackupBucketPatchRequestV1Value, options);
        }
        else if (value.TryGetGcpBackupBucketPatchRequestV1(out var gcpBackupBucketPatchRequestV1Value))
        {
            JsonSerializer.Serialize(writer, gcpBackupBucketPatchRequestV1Value, options);
        }
        else if (value.TryGetAzureBackupBucketPatchRequestV1(out var azureBackupBucketPatchRequestV1Value))
        {
            JsonSerializer.Serialize(writer, azureBackupBucketPatchRequestV1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(BackupBucketPatchRequest)} contains no valid value to serialize.");
        }
    }
}
