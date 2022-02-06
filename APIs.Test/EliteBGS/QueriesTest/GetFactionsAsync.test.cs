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
        var expected = new Response<EBGSFactionsV5>() { docs = new List<EBGSFactionsV5>() { new EBGSFactionsV5() { name = "Faction Name" } } };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EBGSQueries(httpClient);

        var response = await queries.GetFactionsAsync("Faction Name");

        Assert.Equal("Faction Name", response.name);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EBGSQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetFactionsAsync("Issues Abound"));
    }

}
