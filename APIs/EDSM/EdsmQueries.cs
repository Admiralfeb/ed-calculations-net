using System.Net.Http.Json;

using EDCalculations.APIs.EDSM.Models;


namespace EDCalculations.APIs.EDSM;
public class EdsmQueries : QueriesBase
{
    public EdsmQueries(HttpClient client) : base(client) { }
    public async Task<SystemBodies> GetBodiesInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/bodies";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        return await GetFromApi<SystemBodies>(apiURL + query);
    }

    public async Task<SystemFactionInfo> GetFactionsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/factions";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        return await GetFromApi<SystemFactionInfo>(apiURL + query);
    }

    public async Task<SystemStations> GetStationsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/stations";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        return await GetFromApi<SystemStations>(apiURL + query);
    }

    public async Task<IEnumerable<SphereSystem>> GetSystemsinSphereAsync(string systemName, int distance)
    {
        const string apiURL = "https://www.edsm.net/api-v1/sphere-systems";
        string query =
        $"?systemName={Uri.EscapeDataString(systemName)}&radius={distance.ToString()}&showPrimaryStar=1&showInformation=1&showCoordinates=1";

        return (await GetFromApi<IEnumerable<SphereSystem>>(apiURL + query)).Where(x => x.distance > 0);
    }
}
