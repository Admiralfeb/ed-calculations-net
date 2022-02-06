using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

using EDCalculations.EDSM.Models;

using Xunit;

namespace EDCalculations.EDSM.Test.QueriesTest;

public class GetSystemsinSphereAsync
{
    [Fact]
    public async void ShouldCallUsingSystemProvided()
    {
        var expected = new List<SphereSystem>() { new SphereSystem() { name = "Arugbal", distance = 50 } };
        var json = JsonSerializer.Serialize(expected);

        HttpClient httpClient = MockClient.GenerateMockClientWithData(json);

        var queries = new Queries(httpClient);

        var response = (await queries.GetSystemsinSphereAsync("Arugbal", 10)).ToList();

        Assert.Equal(expected[0].name, response[0].name);
        Assert.Equal(expected[0].distance, response[0].distance);
    }

    [Fact]
    public async void ShouldThrowHttpRequestException()
    {
        HttpClient httpClient = MockClient.GenerateMockClientWithError();

        var queries = new Queries(httpClient);

        await Assert.ThrowsAsync<HttpRequestException>(async () => await queries.GetSystemsinSphereAsync("Issues Abound", 20));
    }
}
