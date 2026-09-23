
# Snapshot Bucket

## Class Name

`SnapshotBucket`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`AwsBackupBucketProperties`](../../../doc/models/aws-backup-bucket-properties.md) | SnapshotBucket.FromAwsBackupBucketProperties(AwsBackupBucketProperties awsBackupBucketProperties) |
| [`GcpBackupBucketProperties`](../../../doc/models/gcp-backup-bucket-properties.md) | SnapshotBucket.FromGcpBackupBucketProperties(GcpBackupBucketProperties gcpBackupBucketProperties) |
| [`AzureBackupBucketProperties`](../../../doc/models/azure-backup-bucket-properties.md) | SnapshotBucket.FromAzureBackupBucketProperties(AzureBackupBucketProperties azureBackupBucketProperties) |

## AwsBackupBucketProperties

### Initialization Code

#### Example

```csharp
SnapshotBucket value = SnapshotBucket.FromAwsBackupBucketProperties(
    new AwsBackupBucketProperties
    {
    }
);
```

## GcpBackupBucketProperties

### Initialization Code

#### Example

```csharp
SnapshotBucket value = SnapshotBucket.FromGcpBackupBucketProperties(
    new GcpBackupBucketProperties
    {
    }
);
```

## AzureBackupBucketProperties

### Initialization Code

#### Example

```csharp
SnapshotBucket value = SnapshotBucket.FromAzureBackupBucketProperties(
    new AzureBackupBucketProperties
    {
    }
);
```

