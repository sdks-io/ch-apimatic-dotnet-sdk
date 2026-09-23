
# Backup Bucket

## Class Name

`BackupBucket`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`AwsBackupBucketProperties`](../../../doc/models/aws-backup-bucket-properties.md) | BackupBucket.FromAwsBackupBucketProperties(AwsBackupBucketProperties awsBackupBucketProperties) |
| [`GcpBackupBucketProperties`](../../../doc/models/gcp-backup-bucket-properties.md) | BackupBucket.FromGcpBackupBucketProperties(GcpBackupBucketProperties gcpBackupBucketProperties) |
| [`AzureBackupBucketProperties`](../../../doc/models/azure-backup-bucket-properties.md) | BackupBucket.FromAzureBackupBucketProperties(AzureBackupBucketProperties azureBackupBucketProperties) |

## AwsBackupBucketProperties

### Initialization Code

#### Example

```csharp
BackupBucket value = BackupBucket.FromAwsBackupBucketProperties(
    new AwsBackupBucketProperties
    {
    }
);
```

## GcpBackupBucketProperties

### Initialization Code

#### Example

```csharp
BackupBucket value = BackupBucket.FromGcpBackupBucketProperties(
    new GcpBackupBucketProperties
    {
    }
);
```

## AzureBackupBucketProperties

### Initialization Code

#### Example

```csharp
BackupBucket value = BackupBucket.FromAzureBackupBucketProperties(
    new AzureBackupBucketProperties
    {
    }
);
```

