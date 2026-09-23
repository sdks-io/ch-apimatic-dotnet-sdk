using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(BackupBucketConverter))]
public record BackupBucket
{
    private readonly Optional<AwsBackupBucket> _awsBackupBucketValue;

    private readonly Optional<GcpBackupBucket> _gcpBackupBucketValue;

    private readonly Optional<AzureBackupBucket> _azureBackupBucketValue;

    private BackupBucket(Optional<AwsBackupBucket> awsBackupBucketValue,
        Optional<GcpBackupBucket> gcpBackupBucketValue,
        Optional<AzureBackupBucket> azureBackupBucketValue)
    {
        _awsBackupBucketValue = awsBackupBucketValue;
        _gcpBackupBucketValue = gcpBackupBucketValue;
        _azureBackupBucketValue = azureBackupBucketValue;
    }

    public static BackupBucket AwsBackupBucket(AwsBackupBucket value) =>
        new(Optional<AwsBackupBucket>.Some(value), default, default);

    public static BackupBucket GcpBackupBucket(GcpBackupBucket value) =>
        new(default, Optional<GcpBackupBucket>.Some(value), default);

    public static BackupBucket AzureBackupBucket(AzureBackupBucket value) =>
        new(default, default, Optional<AzureBackupBucket>.Some(value));

    public bool TryGetAwsBackupBucket(out AwsBackupBucket value) =>
        _awsBackupBucketValue.TryGetValue(out value);

    public bool TryGetGcpBackupBucket(out GcpBackupBucket value) =>
        _gcpBackupBucketValue.TryGetValue(out value);

    public bool TryGetAzureBackupBucket(out AzureBackupBucket value) =>
        _azureBackupBucketValue.TryGetValue(out value);

    public static implicit operator BackupBucket(AwsBackupBucket value) => AwsBackupBucket(value);

    public static implicit operator BackupBucket(GcpBackupBucket value) => GcpBackupBucket(value);

    public static implicit operator BackupBucket(AzureBackupBucket value) => AzureBackupBucket(value);
}

file sealed class BackupBucketConverter : JsonConverter<BackupBucket>
{
    public override BackupBucket Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AwsBackupBucket>(root, options, out var awsBackupBucketValue))
        {
            return BackupBucket.AwsBackupBucket(awsBackupBucketValue);
        }
        if (JsonSerializer.TryDeserialize<GcpBackupBucket>(root, options, out var gcpBackupBucketValue))
        {
            return BackupBucket.GcpBackupBucket(gcpBackupBucketValue);
        }
        if (JsonSerializer.TryDeserialize<AzureBackupBucket>(root, options, out var azureBackupBucketValue))
        {
            return BackupBucket.AzureBackupBucket(azureBackupBucketValue);
        }
        throw new JsonException($"JSON does not match AwsBackupBucket or GcpBackupBucket or AzureBackupBucket schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, BackupBucket value, JsonSerializerOptions options)
    {
        if (value.TryGetAwsBackupBucket(out var awsBackupBucketValue))
        {
            JsonSerializer.Serialize(writer, awsBackupBucketValue, options);
        }
        else if (value.TryGetGcpBackupBucket(out var gcpBackupBucketValue))
        {
            JsonSerializer.Serialize(writer, gcpBackupBucketValue, options);
        }
        else if (value.TryGetAzureBackupBucket(out var azureBackupBucketValue))
        {
            JsonSerializer.Serialize(writer, azureBackupBucketValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(BackupBucket)} contains no valid value to serialize.");
        }
    }
}
