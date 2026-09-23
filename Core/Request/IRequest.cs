using System.Net.Http;

namespace OpenApiSpecForClickHouseCloud.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}