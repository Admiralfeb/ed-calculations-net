using System;
using Xunit;

namespace UnitedSystemsCooperative.Utils.EDCalc.Functions.Test;

public class InaraLinkBuilderTest
{
    [Fact]
    public void BuildSystemSearchLink()
    {
        var response = InaraLinkBuilder.BuildSystemSearchString("LHS 3167");

        Assert.Equal("https://inara.cz/starsystem/?search=LHS%203167", response);
    }

    [Fact]
    public void BuildStationLink()
    {
        var response = InaraLinkBuilder.BuildStationSearchString("Arugbal", "Meaney Dock");

        Assert.Equal("https://inara.cz/station/?search=Arugbal%20%5BMeaney%20Dock%5D", response);
    }

    [Fact]
    public void BuildFleetCarrierSearchString()
    {
        var response = InaraLinkBuilder.BuildFleetCarrierSearchString("ABC-123");

        Assert.Equal("https://inara.cz/station/?search=ABC-123", response);
    }

    [Fact]
    public void BuildFleetCarrierSearchStringShouldFail()
    {
        Assert.Throws<ArgumentException>(() => InaraLinkBuilder.BuildFleetCarrierSearchString("dfesersd"));
    }

    [Fact]
    public void BuildMinorFactionSearchString()
    {
        var response = InaraLinkBuilder.BuildMinorFactionSearchString("The Dark Wheel");
        Assert.Equal("https://inara.cz/minorfaction/?search=The%20Dark%20Wheel", response);
    }
}