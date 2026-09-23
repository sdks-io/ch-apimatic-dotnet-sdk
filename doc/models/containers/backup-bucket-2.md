
# Backup Bucket 2

## Class Name

`BackupBucket2`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`AwsBackupBucket`](../../../doc/models/aws-backup-bucket.md) | BackupBucket2.FromAwsBackupBucket(AwsBackupBucket awsBackupBucket) |
| [`GcpBackupBucket`](../../../doc/models/gcp-backup-bucket.md) | BackupBucket2.FromGcpBackupBucket(GcpBackupBucket gcpBackupBucket) |
| [`AzureBackupBucket`](../../../doc/models/azure-backup-bucket.md) | BackupBucket2.FromAzureBackupBucket(AzureBackupBucket azureBackupBucket) |

## AwsBackupBucket

### Initialization Code

#### Example

```csharp
BackupBucket2 value = BackupBucket2.FromAwsBackupBucket(
    new AwsBackupBucket
    {
    }
);
```

## GcpBackupBucket

### Initialization Code

#### Example

```csharp
BackupBucket2 value = BackupBucket2.FromGcpBackupBucket(
    new GcpBackupBucket
    {
    }
);
```

## AzureBackupBucket

### Initialization Code

#### Example

```csharp
BackupBucket2 value = BackupBucket2.FromAzureBackupBucket(
    new AzureBackupBucket
    {
    }
);
```

