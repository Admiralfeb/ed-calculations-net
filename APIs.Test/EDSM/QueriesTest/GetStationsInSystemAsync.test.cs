using System;
using System.Net.Http;
using System.Text.Json;

using EDCalculations.APIs.EDSM;
using EDCalculations.APIs.EDSM.Models;

using Xunit;

namespace EDCalculations.APIs.Test.EDSM.QueriesTest;

public class GetStationsInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemStations() { name = "Arugbal" };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EdsmQueries(httpClient);

        var response = await queries.GetStationsInSystemAsync("Arugbal");

        Assert.Equal(expected.name, response.name);
        Assert.Null(response.stations);
        Assert.Equal(0, response.id);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EdsmQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetStationsInSystemAsync("Issues Abound"));
    }
}
