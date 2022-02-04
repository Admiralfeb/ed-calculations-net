using EDCalculations.EDSM.Models;
using System.Net.Http.Json;
using System.Web;

namespace EDCalculations.EDSM;
public static class Queries
{
    static readonly HttpClient client = new HttpClient();
    public static async Task<SystemBodies> GetBodiesInSystem(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/bodies";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        builder.Query = query.ToString();

        SystemBodies? response = await client.GetFromJsonAsync<SystemBodies>(builder.ToString());

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public static async Task<SystemFactionInfo> GetFactionsInSystem(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/factions";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        builder.Query = query.ToString();

        SystemFactionInfo? response = await client.GetFromJsonAsync<SystemFactionInfo>(builder.ToString());

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public static async Task<SystemStations> GetStationsInSystem(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/stations";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        builder.Query = query.ToString();

        SystemStations? response = await client.GetFromJsonAsync<SystemStations>(builder.ToString());

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public static async Task<IEnumerable<SphereSystem>> GetSystemsinSphere(string systemName, int distance)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/factionss";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        query["radius"] = distance.ToString();
        query["showPrimaryStar"] = "1";
        query["showInformation"] = "1";
        query["showCoordinates"] = "1";

        builder.Query = query.ToString();

        IEnumerable<SphereSystem>? response = await client.GetFromJsonAsync<IEnumerable<SphereSystem>>(builder.ToString());

        if (response != null)
            return response.Where(x => x.distance > 0);
        else
            throw new Exception("Not found");
        throw new NotImplementedException();
    }
}
