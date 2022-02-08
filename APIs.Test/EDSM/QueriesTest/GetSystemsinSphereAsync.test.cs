using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

using EDCalculations.APIs.EDSM;
using EDCalculations.APIs.EDSM.Models;

using Xunit;

namespace EDCalculations.APIs.Test.EDSM.QueriesTest;

public class GetSystemsinSphereAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new List<SphereSystem>() { new SphereSystem() { Name = "Arugbal", Distance = 50 } };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EdsmQueries(httpClient);

        var response = (await queries.GetSystemsinSphereAsync("Arugbal", 10)).ToList();

        Assert.Equal(expected[0].Name, response[0].Name);
        Assert.Equal(expected[0].Distance, response[0].Distance);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EdsmQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetSystemsinSphereAsync("Issues Abound", 20));
    }
}
