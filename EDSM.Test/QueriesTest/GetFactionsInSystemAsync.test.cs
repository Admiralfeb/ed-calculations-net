using System;
using System.Net.Http;
using System.Text.Json;

using EDCalculations.EDSM.Models;

using Xunit;

namespace EDCalculations.EDSM.Test.QueriesTest;

public class GetFactionsInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemFactionInfo() { name = "Arugbal" };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new Queries(httpClient);

        var response = await queries.GetFactionsInSystemAsync("Arugbal");

        Assert.Equal(expected.name, response.name);
        Assert.Equal(null, response.factions);
        Assert.Equal(0, response.id);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new Queries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetFactionsInSystemAsync("Issues Abound"));
    }
}
