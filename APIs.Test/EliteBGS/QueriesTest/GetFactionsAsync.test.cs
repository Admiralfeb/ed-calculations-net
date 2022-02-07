using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using EDCalculations.APIs.EliteBgs;
using EDCalculations.APIs.EliteBgs.Models;
using Xunit;

namespace EDCalculations.APIs.Test.EliteBGS;

public class GetFactionsAsync
{
    [Fact]
    public async void ShouldCallUsingFactionProvided()
    {
        var expected = new Response<EbgsFactionsV5>() { docs = new List<EbgsFactionsV5>() { new EbgsFactionsV5() { name = "Faction Name" } } };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EbgsQueries(httpClient);

        var response = await queries.GetFactionsAsync("Faction Name");

        Assert.Equal("Faction Name", response.name);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EbgsQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetFactionsAsync("Issues Abound"));
    }

}
