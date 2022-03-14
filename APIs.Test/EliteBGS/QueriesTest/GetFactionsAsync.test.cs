using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.EliteBGS;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.EliteBGS.Models;
using Xunit;

namespace UnitedSystemsCooperative.Utils.EDCalc.APIs.Test.EliteBGS.QueriesTest;

public class GetFactionsAsync
{
    [Fact]
    public async void ShouldCallUsingFactionProvided()
    {
        var expected = new Response<EbgsFactionsV5>()
            {Docs = new List<EbgsFactionsV5>() {new EbgsFactionsV5() {Name = "Faction Name"}}};
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EbgsQueries(httpClient);

        var response = await queries.GetFactionsAsync("Faction Name");

        Assert.Equal("Faction Name", response.Name);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EbgsQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetFactionsAsync("Issues Abound"));
    }
}