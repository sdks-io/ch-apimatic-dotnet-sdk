
# Click Stack on Click

## Class Name

`ClickStackOnClick`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackOnClickSearch`](../../../doc/models/click-stack-on-click-search.md) | ClickStackOnClick.FromClickStackOnClickSearch(ClickStackOnClickSearch clickStackOnClickSearch) |
| [`ClickStackOnClickDashboard`](../../../doc/models/click-stack-on-click-dashboard.md) | ClickStackOnClick.FromClickStackOnClickDashboard(ClickStackOnClickDashboard clickStackOnClickDashboard) |
| [`ClickStackOnClickExternal`](../../../doc/models/click-stack-on-click-external.md) | ClickStackOnClick.FromClickStackOnClickExternal(ClickStackOnClickExternal clickStackOnClickExternal) |

## ClickStackOnClickSearch

### Initialization Code

#### Example

```csharp
ClickStackOnClick value = ClickStackOnClick.FromClickStackOnClickSearch(
    new ClickStackOnClickSearch
    {
        Type = "search",
        Target = ClickStackOnClickTarget.FromClickStackOnClickTargetIdVariant(
            new ClickStackOnClickTargetIdVariant
            {
                Mode = "id",
                Id = "65f5e4a3b9e77c001a567890",
            }
        ),
        WhereTemplate = "ServiceName = '{{ServiceName}}'",
    }
);
```

## ClickStackOnClickDashboard

### Initialization Code

#### Example

```csharp
ClickStackOnClick value = ClickStackOnClick.FromClickStackOnClickDashboard(
    new ClickStackOnClickDashboard
    {
        Type = "dashboard",
        Target = ClickStackOnClickTarget.FromClickStackOnClickTargetIdVariant(
            new ClickStackOnClickTargetIdVariant
            {
                Mode = "id",
                Id = "65f5e4a3b9e77c001a567890",
            }
        ),
        WhereTemplate = "ServiceName = '{{ServiceName}}'",
    }
);
```

## ClickStackOnClickExternal

### Initialization Code

#### Example

```csharp
ClickStackOnClick value = ClickStackOnClick.FromClickStackOnClickExternal(
    new ClickStackOnClickExternal
    {
        Type = "external",
        UrlTemplate = "https://example.com/d/abc?var-service={{ServiceName}}",
    }
);
```

