namespace EDCalculations.Functions;

public static class InaraLinkBuilder
{
    private const string inaraBaseUrl = "https://inara.cz";

    public static string BuildSystemSearchString(string system)
    {
        string searchParam = Uri.EscapeDataString(system);
        return $"{inaraBaseUrl}/starsystem/?search={searchParam}";
    }

    public static string BuildStationSearchString(string system, string station)
    {
        string searchParam = Uri.EscapeDataString($"{system} [{station}]");
        return $"{inaraBaseUrl}/station/?search={searchParam}";
    }

    public static string BuildFleetCarrierSearchString(string carrierId)
    {
        string searchParam = Uri.EscapeDataString(carrierId);
        return $"{inaraBaseUrl}/station/?search={searchParam}";
    }

    public static string BuildMinorFactionSearchString(string factionName)
    {
        string searchParam = Uri.EscapeDataString(factionName);
        return $"{inaraBaseUrl}/minorfaction/?search={searchParam}";
    }

}

public enum SearchType
{
    System,
    Station,
    FleetCarrier,
    MinorFaction
}
