
# Scim Service Provider Config

*This model accepts additional fields of type object.*

## Structure

`ScimServiceProviderConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. |
| `DocumentationUri` | `string` | Optional | URI of the service documentation. |
| `Patch` | [`ScimServiceProviderConfigPatch`](../../doc/models/scim-service-provider-config-patch.md) | Required | - |
| `Bulk` | [`ScimServiceProviderConfigBulk`](../../doc/models/scim-service-provider-config-bulk.md) | Required | - |
| `Filter` | [`ScimServiceProviderConfigFilter`](../../doc/models/scim-service-provider-config-filter.md) | Required | - |
| `ChangePassword` | [`ScimBooleanFeature`](../../doc/models/scim-boolean-feature.md) | Required | - |
| `Sort` | [`ScimBooleanFeature`](../../doc/models/scim-boolean-feature.md) | Required | - |
| `Etag` | [`ScimBooleanFeature`](../../doc/models/scim-boolean-feature.md) | Required | - |
| `AuthenticationSchemes` | [`List<ScimAuthenticationScheme>`](../../doc/models/scim-authentication-scheme.md) | Required | Supported authentication schemes. |
| `Meta` | [`ScimServiceProviderConfigMeta`](../../doc/models/scim-service-provider-config-meta.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimServiceProviderConfig scimServiceProviderConfig = new ScimServiceProviderConfig
{
    Schemas = new List<string>
    {
        "schemas7",
        "schemas6",
    },
    Patch = new ScimServiceProviderConfigPatch
    {
        Supported = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Bulk = new ScimServiceProviderConfigBulk
    {
        Supported = false,
        MaxOperations = 148,
        MaxPayloadSize = 104,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Filter = new ScimServiceProviderConfigFilter
    {
        Supported = false,
        MaxResults = 200,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ChangePassword = new ScimBooleanFeature
    {
        Supported = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Sort = new ScimBooleanFeature
    {
        Supported = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Etag = new ScimBooleanFeature
    {
        Supported = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    AuthenticationSchemes = new List<ScimAuthenticationScheme>
    {
        new ScimAuthenticationScheme
        {
            Type = "type0",
            Name = "name0",
            Description = "description0",
            SpecUri = "specUri4",
            Primary = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Meta = new ScimServiceProviderConfigMeta
    {
        ResourceType = "resourceType6",
        Location = "location6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    DocumentationUri = "documentationUri8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

