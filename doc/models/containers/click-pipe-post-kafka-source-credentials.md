
# Click Pipe Post Kafka Source Credentials

## Class Name

`ClickPipePostKafkaSourceCredentials`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`Plain`](../../../doc/models/plain.md) | ClickPipePostKafkaSourceCredentials.FromPLAIN(Plain plain) |
| [`MskIamUser`](../../../doc/models/msk-iam-user.md) | ClickPipePostKafkaSourceCredentials.FromMskIamUser(MskIamUser mskIamUser) |
| [`AzureEventHub`](../../../doc/models/azure-event-hub.md) | ClickPipePostKafkaSourceCredentials.FromAzureEventHub(AzureEventHub azureEventHub) |
| [`MutualTls`](../../../doc/models/mutual-tls.md) | ClickPipePostKafkaSourceCredentials.FromMutualTLS(MutualTls mutualTls) |

## Plain

### Initialization Code

#### Example

```csharp
ClickPipePostKafkaSourceCredentials value = ClickPipePostKafkaSourceCredentials.FromPLAIN(
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
ClickPipePostKafkaSourceCredentials value = ClickPipePostKafkaSourceCredentials.FromMskIamUser(
    new MskIamUser
    {
    }
);
```

## AzureEventHub

### Initialization Code

#### Example

```csharp
ClickPipePostKafkaSourceCredentials value = ClickPipePostKafkaSourceCredentials.FromAzureEventHub(
    new AzureEventHub
    {
    }
);
```

## MutualTls

### Initialization Code

#### Example

```csharp
ClickPipePostKafkaSourceCredentials value = ClickPipePostKafkaSourceCredentials.FromMutualTLS(
    new MutualTls
    {
    }
);
```

