using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models.AnyOf;

[JsonConverter(typeof(BackupBucketPropertiesConverter))]
public record BackupBucketProperties
{
    private readonly Optional<AwsBackupBucketProperties> _awsBackupBucketPropertiesValue;

    private readonly Optional<GcpBackupBucketProperties> _gcpBackupBucketPropertiesValue;

    private readonly Optional<AzureBackupBucketProperties> _azureBackupBucketPropertiesValue;

    private BackupBucketProperties(Optional<AwsBackupBucketProperties> awsBackupBucketPropertiesValue,
        Optional<GcpBackupBucketProperties> gcpBackupBucketPropertiesValue,
        Optional<AzureBackupBucketProperties> azureBackupBucketPropertiesValue)
    {
        _awsBackupBucketPropertiesValue = awsBackupBucketPropertiesValue;
        _gcpBackupBucketPropertiesValue = gcpBackupBucketPropertiesValue;
        _azureBackupBucketPropertiesValue = azureBackupBucketPropertiesValue;
    }

    public static BackupBucketProperties AwsBackupBucketProperties(AwsBackupBucketProperties value) =>
        new(Optional<AwsBackupBucketProperties>.Some(value), default, default);

    public static BackupBucketProperties GcpBackupBucketProperties(GcpBackupBucketProperties value) =>
        new(default, Optional<GcpBackupBucketProperties>.Some(value), default);

    public static BackupBucketProperties AzureBackupBucketProperties(AzureBackupBucketProperties value) =>
        new(default, default, Optional<AzureBackupBucketProperties>.Some(value));

    public bool TryGetAwsBackupBucketProperties(out AwsBackupBucketProperties value) =>
        _awsBackupBucketPropertiesValue.TryGetValue(out value);

    public bool TryGetGcpBackupBucketProperties(out GcpBackupBucketProperties value) =>
        _gcpBackupBucketPropertiesValue.TryGetValue(out value);

    public bool TryGetAzureBackupBucketProperties(out AzureBackupBucketProperties value) =>
        _azureBackupBucketPropertiesValue.TryGetValue(out value);

    public static implicit operator BackupBucketProperties(AwsBackupBucketProperties value) =>
        AwsBackupBucketProperties(value);

    public static implicit operator BackupBucketProperties(GcpBackupBucketProperties value) =>
        GcpBackupBucketProperties(value);

    public static implicit operator BackupBucketProperties(AzureBackupBucketProperties value) =>
        AzureBackupBucketProperties(value);
}

file sealed class BackupBucketPropertiesConverter : JsonConverter<BackupBucketProperties>
{
    public override BackupBucketProperties Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AwsBackupBucketProperties>(root,
            options,
            out var awsBackupBucketPropertiesValue))
        {
            return BackupBucketProperties.AwsBackupBucketProperties(awsBackupBucketPropertiesValue);
        }
        if (JsonSerializer.TryDeserialize<GcpBackupBucketProperties>(root,
            options,
            out var gcpBackupBucketPropertiesValue))
        {
            return BackupBucketProperties.GcpBackupBucketProperties(gcpBackupBucketPropertiesValue);
        }
        if (JsonSerializer.TryDeserialize<AzureBackupBucketProperties>(root,
            options,
            out var azureBackupBucketPropertiesValue))
        {
            return BackupBucketProperties.AzureBackupBucketProperties(azureBackupBucketPropertiesValue);
        }
        throw new JsonException($"JSON does not match AwsBackupBucketProperties or GcpBackupBucketProperties or AzureBackupBucketProperties schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, BackupBucketProperties value, JsonSerializerOptions options)
    {
        if (value.TryGetAwsBackupBucketProperties(out var awsBackupBucketPropertiesValue))
        {
            JsonSerializer.Serialize(writer, awsBackupBucketPropertiesValue, options);
        }
        else if (value.TryGetGcpBackupBucketProperties(out var gcpBackupBucketPropertiesValue))
        {
            JsonSerializer.Serialize(writer, gcpBackupBucketPropertiesValue, options);
        }
        else if (value.TryGetAzureBackupBucketProperties(out var azureBackupBucketPropertiesValue))
        {
            JsonSerializer.Serialize(writer, azureBackupBucketPropertiesValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(BackupBucketProperties)} contains no valid value to serialize.");
        }
    }
}
