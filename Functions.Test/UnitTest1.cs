using Xunit;

namespace EDCalculations.Functions.Test;

public class UnitTest1
{
    [Fact]
    public void BuildInaraLinkShouldReturnStation()
    {
        var response = EDCalcFunctions.BuildInaraLink("Arugbal", "Meaney Dock");

        Assert.Equal("https://inara.cz/station/?search=Arugbal%20[Meaney%20Dock]", response);
    }
}
