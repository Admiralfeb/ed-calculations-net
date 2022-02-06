using System.Net.Http.Json;

using EDCalculations.APIs.EDSM.Models;


namespace EDCalculations.APIs.EDSM;
public class EdsmQueries
{
    private readonly HttpClient Http;

    public EdsmQueries(HttpClient http)
    {
        Http = http;
    }
    public async Task<SystemBodies> GetBodiesInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/bodies?systemName={Uri.EscapeDataString(systemName)}";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        SystemBodies? response = await Http.GetFromJsonAsync<SystemBodies>(apiURL + query);

        if (response != null)
            return response;
        else
            throw new Exception("Bodies is null");
    }

    public async Task<SystemFactionInfo> GetFactionsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/factions";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        SystemFactionInfo? response = await Http.GetFromJsonAsync<SystemFactionInfo>(apiURL + query);

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public async Task<SystemStations> GetStationsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/stations";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        SystemStations? response = await Http.GetFromJsonAsync<SystemStations>(apiURL + query);

        if (response != null)
            return response;
        else
            throw new Exception("Not found");
    }

    public async Task<IEnumerable<SphereSystem>> GetSystemsinSphereAsync(string systemName, int distance)
    {
        const string apiURL = "https://www.edsm.net/api-v1/sphere-systems";
        string query =
        $"?systemName={Uri.EscapeDataString(systemName)}&radius={distance.ToString()}&showPrimaryStar=1&showInformation=1&showCoordinates=1";

        IEnumerable<SphereSystem>? response = await Http.GetFromJsonAsync<IEnumerable<SphereSystem>>(apiURL + query);

        if (response != null)
            return response.Where(x => x.distance > 0);
        else
            throw new Exception("Not found");
    }
}
