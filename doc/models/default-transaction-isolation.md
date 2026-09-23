
# Default Transaction Isolation

Sets the default transaction isolation level for new transactions.

Find out more here: [https://postgresqlco.nf/doc/en/param/default_transaction_isolation/](https://postgresqlco.nf/doc/en/param/default_transaction_isolation/)

## Enumeration

`DefaultTransactionIsolation`

## Fields

| Name |
|  --- |
| `EnumReadCommitted` |
| `EnumRepeatableRead` |
| `Serializable` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

DefaultTransactionIsolation defaultTransactionIsolation = DefaultTransactionIsolation.EnumRepeatableRead;
```

