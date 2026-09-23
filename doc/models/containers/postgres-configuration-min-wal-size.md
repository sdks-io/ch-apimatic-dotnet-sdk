
# Postgres Configuration Min Wal Size

## Class Name

`PostgresConfigurationMinWalSize`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | PostgresConfigurationMinWalSize.FromString(string mString) |
| `int` | PostgresConfigurationMinWalSize.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
PostgresConfigurationMinWalSize value = PostgresConfigurationMinWalSize.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
PostgresConfigurationMinWalSize value = PostgresConfigurationMinWalSize.FromNumber(32768);
```

