
# Release Channel

Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel.

## Enumeration

`ReleaseChannel`

## Fields

| Name |
|  --- |
| `Slow` |
| `Default` |
| `Fast` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

ReleaseChannel releaseChannel = ReleaseChannel.Default;
```

