
# Click Pipe Patch Kafka Source Credentials

## Class Name

`ClickPipePatchKafkaSourceCredentials`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`Plain`](../../../doc/models/plain.md) | ClickPipePatchKafkaSourceCredentials.FromPLAIN(Plain plain) |
| [`MskIamUser`](../../../doc/models/msk-iam-user.md) | ClickPipePatchKafkaSourceCredentials.FromMskIamUser(MskIamUser mskIamUser) |
| [`AzureEventHub`](../../../doc/models/azure-event-hub.md) | ClickPipePatchKafkaSourceCredentials.FromAzureEventHub(AzureEventHub azureEventHub) |
| [`MutualTls`](../../../doc/models/mutual-tls.md) | ClickPipePatchKafkaSourceCredentials.FromMutualTLS(MutualTls mutualTls) |

## Plain

### Initialization Code

#### Example

```csharp
ClickPipePatchKafkaSourceCredentials value = ClickPipePatchKafkaSourceCredentials.FromPLAIN(
    new Plain
    {
        Username = "postgres_user",
        Password = "your_secure_password",
    }
);
```

## MskIamUser

### Initialization Code

#### Example

```csharp
ClickPipePatchKafkaSourceCredentials value = ClickPipePatchKafkaSourceCredentials.FromMskIamUser(
    new MskIamUser
    {
    }
);
```

## AzureEventHub

### Initialization Code

#### Example

```csharp
ClickPipePatchKafkaSourceCredentials value = ClickPipePatchKafkaSourceCredentials.FromAzureEventHub(
    new AzureEventHub
    {
    }
);
```

## MutualTls

### Initialization Code

#### Example

```csharp
ClickPipePatchKafkaSourceCredentials value = ClickPipePatchKafkaSourceCredentials.FromMutualTLS(
    new MutualTls
    {
    }
);
```

