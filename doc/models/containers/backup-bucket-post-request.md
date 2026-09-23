
# Backup Bucket Post Request

## Class Name

`BackupBucketPostRequest`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`AwsBackupBucketPostRequestV1`](../../../doc/models/aws-backup-bucket-post-request-v1.md) | BackupBucketPostRequest.FromAwsBackupBucketPostRequestV1(AwsBackupBucketPostRequestV1 awsBackupBucketPostRequestV1) |
| [`GcpBackupBucketPostRequestV1`](../../../doc/models/gcp-backup-bucket-post-request-v1.md) | BackupBucketPostRequest.FromGcpBackupBucketPostRequestV1(GcpBackupBucketPostRequestV1 gcpBackupBucketPostRequestV1) |
| [`AzureBackupBucketPostRequestV1`](../../../doc/models/azure-backup-bucket-post-request-v1.md) | BackupBucketPostRequest.FromAzureBackupBucketPostRequestV1(AzureBackupBucketPostRequestV1 azureBackupBucketPostRequestV1) |

## AwsBackupBucketPostRequestV1

### Initialization Code

#### Example

```csharp
BackupBucketPostRequest value = BackupBucketPostRequest.FromAwsBackupBucketPostRequestV1(
    new AwsBackupBucketPostRequestV1
    {
    }
);
```

## GcpBackupBucketPostRequestV1

### Initialization Code

#### Example

```csharp
BackupBucketPostRequest value = BackupBucketPostRequest.FromGcpBackupBucketPostRequestV1(
    new GcpBackupBucketPostRequestV1
    {
    }
);
```

## AzureBackupBucketPostRequestV1

### Initialization Code

#### Example

```csharp
BackupBucketPostRequest value = BackupBucketPostRequest.FromAzureBackupBucketPostRequestV1(
    new AzureBackupBucketPostRequestV1
    {
    }
);
```

