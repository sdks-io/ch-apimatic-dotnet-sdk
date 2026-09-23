using System.Net.Http;

namespace OpenApiSpecForClickHouseCloud.Core.Extensions;

internal static class HttpContentExtension
{
    extension(HttpContent)
    {
        public static HttpContent None => null!;
    }
}
