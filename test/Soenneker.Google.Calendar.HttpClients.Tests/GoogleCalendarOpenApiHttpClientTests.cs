using Soenneker.Google.Calendar.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Google.Calendar.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GoogleCalendarOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IGoogleCalendarOpenApiHttpClient _httpclient;

    public GoogleCalendarOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IGoogleCalendarOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
