using System;
using System.Net.Http;
using System.Text.Json;

using EDCalculations.APIs.EDSM;
using EDCalculations.APIs.EDSM.Models;

using Xunit;

namespace EDCalculations.APIs.Test.EDSM.QueriesTest;

public class GetFactionsInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemFactionInfo() { name = "Arugbal" };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EdsmQueries(httpClient);

        var response = await queries.GetFactionsInSystemAsync("Arugbal");

        Assert.Equal(expected.name, response.name);
        Assert.Null(response.factions);
        Assert.Equal(0, response.id);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EdsmQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetFactionsInSystemAsync("Issues Abound"));
    }
}
