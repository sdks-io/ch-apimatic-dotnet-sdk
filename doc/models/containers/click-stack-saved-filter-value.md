
# Click Stack Saved Filter Value

## Class Name

`ClickStackSavedFilterValue`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackSqlSavedFilterValue`](../../../doc/models/click-stack-sql-saved-filter-value.md) | ClickStackSavedFilterValue.FromClickStackSqlSavedFilterValue(ClickStackSqlSavedFilterValue clickStackSqlSavedFilterValue) |
| [`ClickStackVariableSavedFilterValue`](../../../doc/models/click-stack-variable-saved-filter-value.md) | ClickStackSavedFilterValue.FromClickStackVariableSavedFilterValue(ClickStackVariableSavedFilterValue clickStackVariableSavedFilterValue) |

## ClickStackSqlSavedFilterValue

### Initialization Code

#### Example

```csharp
ClickStackSavedFilterValue value = ClickStackSavedFilterValue.FromClickStackSqlSavedFilterValue(
    new ClickStackSqlSavedFilterValue
    {
        Condition = "ServiceName IN ('hdx-oss-dev-api')",
        Type = Type18.Sql,
    }
);
```

## ClickStackVariableSavedFilterValue

### Initialization Code

#### Example

```csharp
ClickStackSavedFilterValue value = ClickStackSavedFilterValue.FromClickStackVariableSavedFilterValue(
    new ClickStackVariableSavedFilterValue
    {
        Type = "variable",
        Name = "service",
        Values = new List<string>
        {
            "hdx-oss-dev-api",
        },
    }
);
```

