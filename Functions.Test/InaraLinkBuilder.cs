using Xunit;

namespace EDCalculations.Functions.Test;

public class UnitTest1
{
    [Fact]
    public void BuildStationLink()
    {
        var response = InaraLinkBuilder.BuildStationSearchString("Arugbal", "Meaney Dock");

        Assert.Equal("https://inara.cz/station/?search=Arugbal%20[Meaney%20Dock]", response);
    }
}
