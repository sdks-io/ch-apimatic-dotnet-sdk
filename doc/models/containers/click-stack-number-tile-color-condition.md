
# Click Stack Number Tile Color Condition

## Class Name

`ClickStackNumberTileColorCondition`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackNumericColorCondition`](../../../doc/models/click-stack-numeric-color-condition.md) | ClickStackNumberTileColorCondition.FromClickStackNumericColorCondition(ClickStackNumericColorCondition clickStackNumericColorCondition) |
| [`ClickStackBetweenColorCondition`](../../../doc/models/click-stack-between-color-condition.md) | ClickStackNumberTileColorCondition.FromClickStackBetweenColorCondition(ClickStackBetweenColorCondition clickStackBetweenColorCondition) |
| [`ClickStackEqualityColorCondition`](../../../doc/models/click-stack-equality-color-condition.md) | ClickStackNumberTileColorCondition.FromClickStackEqualityColorCondition(ClickStackEqualityColorCondition clickStackEqualityColorCondition) |

## ClickStackNumericColorCondition

### Initialization Code

#### Example

```csharp
ClickStackNumberTileColorCondition value = ClickStackNumberTileColorCondition.FromClickStackNumericColorCondition(
    new ClickStackNumericColorCondition
    {
        MOperator = Operator.Gt,
        MValue = 100,
        Color = Color1.Chartgreen,
        Label = "High",
    }
);
```

## ClickStackBetweenColorCondition

### Initialization Code

#### Example

```csharp
ClickStackNumberTileColorCondition value = ClickStackNumberTileColorCondition.FromClickStackBetweenColorCondition(
    new ClickStackBetweenColorCondition
    {
        MOperator = "between",
        MValue = new List<double>
        {
            100,
            500,
        },
        Color = Color1.Chartcyan,
        Label = "Warning",
    }
);
```

## ClickStackEqualityColorCondition

### Initialization Code

#### Example

```csharp
ClickStackNumberTileColorCondition value = ClickStackNumberTileColorCondition.FromClickStackEqualityColorCondition(
    new ClickStackEqualityColorCondition
    {
        MOperator = Operator1.Eq,
        MValue = ClickStackEqualityColorConditionValue.FromPrecision(58.94),
        Color = Color1.Chartwarning,
        Label = "Healthy",
    }
);
```

