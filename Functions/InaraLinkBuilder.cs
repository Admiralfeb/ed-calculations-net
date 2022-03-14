using System.Text.RegularExpressions;

namespace UnitedSystemsCooperative.Utils.EDCalc.Functions;

public static class InaraLinkBuilder
{
#pragma warning disable S1075
    private const string inaraBaseUrl = "https://inara.cz";
#pragma warning restore S1075

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
        Regex carrierExp = new(@"^[A-Z0-9]{3}-[A-Z0-9]{3}$");
        if (!carrierExp.IsMatch(carrierId.ToUpper()))
        {
            throw new ArgumentException("CarrierId must be in format '###-###' where # is a letter or number");
        }

        string searchParam = Uri.EscapeDataString(carrierId);
        return $"{inaraBaseUrl}/station/?search={searchParam}";
    }

    public static string BuildMinorFactionSearchString(string factionName)
    {
        string searchParam = Uri.EscapeDataString(factionName);
        return $"{inaraBaseUrl}/minorfaction/?search={searchParam}";
    }
}