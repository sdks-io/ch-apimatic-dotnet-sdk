
# Click Stack on Click Target

## Class Name

`ClickStackOnClickTarget`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackOnClickTargetIdVariant`](../../../doc/models/click-stack-on-click-target-id-variant.md) | ClickStackOnClickTarget.FromClickStackOnClickTargetIdVariant(ClickStackOnClickTargetIdVariant clickStackOnClickTargetIdVariant) |
| [`ClickStackOnClickTargetTemplateVariant`](../../../doc/models/click-stack-on-click-target-template-variant.md) | ClickStackOnClickTarget.FromClickStackOnClickTargetTemplateVariant(ClickStackOnClickTargetTemplateVariant clickStackOnClickTargetTemplateVariant) |

## ClickStackOnClickTargetIdVariant

### Initialization Code

#### Example

```csharp
ClickStackOnClickTarget value = ClickStackOnClickTarget.FromClickStackOnClickTargetIdVariant(
    new ClickStackOnClickTargetIdVariant
    {
        Mode = "id",
        Id = "65f5e4a3b9e77c001a567890",
    }
);
```

## ClickStackOnClickTargetTemplateVariant

### Initialization Code

#### Example

```csharp
ClickStackOnClickTarget value = ClickStackOnClickTarget.FromClickStackOnClickTargetTemplateVariant(
    new ClickStackOnClickTargetTemplateVariant
    {
        Mode = "template",
        Template = "{{ServiceName}}",
    }
);
```

