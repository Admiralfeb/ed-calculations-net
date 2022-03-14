using System.Net.Http;
using System.Text.Json;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM.Models;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.Test;
using Xunit;

namespace EDCalculations.APIs.Test.EDSM.QueriesTest;

public class GetFactionsInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemFactionInfo() {Name = "Arugbal"};
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EdsmQueries(httpClient);

        var response = await queries.GetFactionsInSystemAsync("Arugbal");

        Assert.Equal(expected.Name, response.Name);
        Assert.Equal(0, response.Id);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EdsmQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () =>
            await queries.GetFactionsInSystemAsync("Issues Abound"));
    }
}