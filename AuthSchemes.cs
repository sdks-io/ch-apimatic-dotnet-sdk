using OpenApiSpecForClickHouseCloud.Core.Authentication;
using OpenApiSpecForClickHouseCloud.Core.Authentication.Basic;

namespace OpenApiSpecForClickHouseCloud;

internal sealed class AuthSchemes
{
    public IAuthScheme BasicAuth { get; }

    public AuthSchemes(OpenApiSpecForClickHouseCloudClientOptions options)
    {
        BasicAuth = BasicAuthScheme.Create(options.BasicAuth);
    }
}
