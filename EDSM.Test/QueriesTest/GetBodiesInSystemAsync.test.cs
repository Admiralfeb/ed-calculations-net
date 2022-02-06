using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using EDCalculations.EDSM.Models;

using Moq;
using Moq.Protected;

using Xunit;


namespace EDCalculations.EDSM.Test.QueriesTest;

public class GetBodiesInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemBodies() { name = "Arugbal" };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = GenerateMockClient(json);

        var queries = new Queries(httpClient);

        var bodies = await queries.GetBodiesInSystemAsync("Arugbal");

        Assert.Equal(expected.name, bodies.name);
        Assert.Equal(null, bodies.bodies);
        Assert.Equal(0, bodies.id);
    }

    private HttpClient GenerateMockClient(string jsonValue)
    {
        HttpResponseMessage httpResponse = new HttpResponseMessage();
        httpResponse.StatusCode = System.Net.HttpStatusCode.OK;
        httpResponse.Content = new StringContent(jsonValue, Encoding.UTF8, "application/json");

        Mock<HttpMessageHandler> mockHandler = new();
        mockHandler.Protected()
        .Setup<Task<HttpResponseMessage>>("SendAsync",
        ItExpr.IsAny<HttpRequestMessage>(),
        ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(httpResponse);

        HttpClient httpClient = new(mockHandler.Object);

        return httpClient;
    }
}
