namespace EDCalculations.Functions;
public static class EDCalcFunctions
{
    private const string inaraBaseUrl = "https://inara.cz";

    /// <summary>
    /// This builds Inara links for Systems, FleetCarriers, or Minor Factions.
    ///
    /// Use the overload for Stations as it requires a second field.
    /// </summary>
    /// <param name="search"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static void BuildInaraLink(SearchType search, string value)
    {
        switch (search)
        {
            case SearchType.System:

                break;
            case SearchType.FleetCarrier:
                break;
            case SearchType.MinorFaction:
                break;
            default:
                break;
        }
    }

    public static string BuildInaraLink(string system, string station)
    {
        string searchParam = Uri.EscapeDataString($"{system} [{station}]");
        return $"{inaraBaseUrl}/station/?search={searchParam}";
    }

}
