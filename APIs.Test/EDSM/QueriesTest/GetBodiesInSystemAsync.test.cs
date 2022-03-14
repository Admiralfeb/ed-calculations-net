using System.Net.Http;
using System.Text.Json;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM.Models;
using UnitedSystemsCooperative.Utils.EDCalc.APIs.Test;
using Xunit;

namespace EDCalculations.APIs.Test.EDSM.QueriesTest;

public class GetBodiesInSystemAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new SystemBodies() {Name = "Arugbal"};
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new EdsmQueries(httpClient);

        var bodies = await queries.GetBodiesInSystemAsync("Arugbal");

        Assert.Equal(expected.Name, bodies.Name);
        Assert.Equal(0, bodies.Id);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new EdsmQueries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(
            async () => await queries.GetBodiesInSystemAsync("Issues Abound"));
    }
}