using EDCalculations.EDSM.Models;
using System.Net.Http.Json;
using System.Web;

namespace EDCalculations.EDSM;
public class Queries
{
    private readonly HttpClient Http;

    public Queries(HttpClient http)
    {
        Http = http;
    }
    public async Task<SystemBodies> GetBodiesInSystemAsync(string systemName)
    {
        string apiURL = $"https://www.edsm.net/api-system-v1/bodies?systemName={systemName}";

        SystemBodies? response = await Http.GetFromJsonAsync<SystemBodies>(apiURL);

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public async Task<SystemFactionInfo> GetFactionsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/factions";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        builder.Query = query.ToString();

        SystemFactionInfo? response = await Http.GetFromJsonAsync<SystemFactionInfo>(builder.ToString());

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public async Task<SystemStations> GetStationsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/stations";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        builder.Query = query.ToString();

        SystemStations? response = await Http.GetFromJsonAsync<SystemStations>(builder.ToString());

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public async Task<IEnumerable<SphereSystem>> GetSystemsinSphereAsync(string systemName, int distance)
    {
        const string apiURL = "https://www.edsm.net/api-v1/sphere-systems";
        var builder = new UriBuilder(apiURL);
        builder.Port = -1;

        var query = HttpUtility.ParseQueryString(builder.Query);
        query["systemName"] = systemName;
        query["radius"] = distance.ToString();
        query["showPrimaryStar"] = "1";
        query["showInformation"] = "1";
        query["showCoordinates"] = "1";

        builder.Query = query.ToString();

        IEnumerable<SphereSystem>? response = await Http.GetFromJsonAsync<IEnumerable<SphereSystem>>(builder.ToString());

        if (response != null)
            return response.Where(x => x.distance > 0);
        else
            throw new Exception("Not found");
        throw new NotImplementedException();
    }
}
