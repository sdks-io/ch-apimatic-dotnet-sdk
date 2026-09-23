using System.Net.Http;
using OpenApiSpecForClickHouseCloud.Api;
using OpenApiSpecForClickHouseCloud.Core;
using OpenApiSpecForClickHouseCloud.Core.Logging;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud;

public sealed class OpenApiSpecForClickHouseCloudClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public OpenApiSpecForClickHouseCloudClient(HttpClient httpClient,
        OpenApiSpecForClickHouseCloudClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "OpenApiSpecForClickHouseCloudClient/1.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "OpenApiSpecForClickHouseCloudClient");
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options);
    }

    public ApiKeys ApiKeys => field ??= new ApiKeys(_rawClient, _server, _auth);

    public BackupApi BackupApi => field ??= new BackupApi(_rawClient, _server, _auth);

    public Billing Billing => field ??= new Billing(_rawClient, _server, _auth);

    public ClickPipes ClickPipes => field ??= new ClickPipes(_rawClient, _server, _auth);

    public ClickStack ClickStack => field ??= new ClickStack(_rawClient, _server, _auth);

    public OrganizationApi OrganizationApi => field ??= new OrganizationApi(_rawClient, _server, _auth);

    public Postgres Postgres => field ??= new Postgres(_rawClient, _server, _auth);

    public Prometheus Prometheus => field ??= new Prometheus(_rawClient, _server, _auth);

    public QueryApiEndpoints QueryApiEndpoints => field ??= new QueryApiEndpoints(_rawClient, _server, _auth);

    public RoleManagement RoleManagement => field ??= new RoleManagement(_rawClient, _server, _auth);

    public ServiceApi ServiceApi => field ??= new ServiceApi(_rawClient, _server, _auth);

    public SnapshotApi SnapshotApi => field ??= new SnapshotApi(_rawClient, _server, _auth);

    public UdfApi UdfApi => field ??= new UdfApi(_rawClient, _server, _auth);

    public UserManagement UserManagement => field ??= new UserManagement(_rawClient, _server, _auth);
}
