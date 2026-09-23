
# Postgres Configuration Wal Keep Size

## Class Name

`PostgresConfigurationWalKeepSize`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationWalKeepSize.FromString(string mString) |
| `int` | PostgresConfigurationWalKeepSize.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationWalKeepSize value = PostgresConfigurationWalKeepSize.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationWalKeepSize value = PostgresConfigurationWalKeepSize.FromNumber(0);
```

