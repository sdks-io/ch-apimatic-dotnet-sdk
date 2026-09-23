
# Service Clickhouse Setting Value

Setting value in its native JSON type. Use the settings schema endpoint for per-setting constraints.

## Class Name

`ServiceClickhouseSettingValue`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | ServiceClickhouseSettingValue.FromString(string mString) |
| `int` | ServiceClickhouseSettingValue.FromNumber(int number) |

## string

### Initialization Code

#### Example

```csharp
ServiceClickhouseSettingValue value = ServiceClickhouseSettingValue.FromString("String0");
```

## int

### Initialization Code

#### Example

```csharp
ServiceClickhouseSettingValue value = ServiceClickhouseSettingValue.FromNumber(0);
```

