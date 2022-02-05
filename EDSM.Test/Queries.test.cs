using System;
using Xunit;
using SoloX.CodeQuality.Test.Helpers.Http;
using EDCalculations.EDSM.Models;

namespace EDCalculations.EDSM.Test.Queries;

public class GetBodiesInSystemAsync
{
    [Fact]
    public void ShouldCallUsingSystemProvided()
    {
        var httpClient = new HttpClientMockBuilder()
        .WithBaseAddress(new Uri("https://www.edsm.net/api-system-v1"))
        .WithRequest("/stations")
        .RespondingJsonContent(request => new SystemBodies()
        {
            name = "Arugbal"
        })
        .Build();


    }
}
