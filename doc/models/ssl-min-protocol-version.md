
# Ssl Min Protocol Version

Sets the minimum SSL/TLS protocol version allowed for client connections.

Find out more here: [https://postgresqlco.nf/doc/en/param/ssl_min_protocol_version/](https://postgresqlco.nf/doc/en/param/ssl_min_protocol_version/)

## Enumeration

`SslMinProtocolVersion`

## Fields

| Name |
|  --- |
| `TlSv1` |
| `EnumTlSv11` |
| `EnumTlSv12` |
| `EnumTlSv13` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

SslMinProtocolVersion sslMinProtocolVersion = SslMinProtocolVersion.EnumTlSv12;
```

