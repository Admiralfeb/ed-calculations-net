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

        try
        {
            return await GetFromApi<SystemBodies>(apiURL + query);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<SystemFactionInfo> GetFactionsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/factions";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        try
        {
            return await GetFromApi<SystemFactionInfo>(apiURL + query);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<SystemStations> GetStationsInSystemAsync(string systemName)
    {
        const string apiURL = "https://www.edsm.net/api-system-v1/stations";
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";
        try
        {
            return await GetFromApi<SystemStations>(apiURL + query);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<SphereSystem>> GetSystemsinSphereAsync(string systemName, int distance)
    {
        const string apiURL = "https://www.edsm.net/api-v1/sphere-systems";
        string query =
        $"?systemName={Uri.EscapeDataString(systemName)}&radius={distance.ToString()}&showPrimaryStar=1&showInformation=1&showCoordinates=1";
        try
        {
            return (await GetFromApi<IEnumerable<SphereSystem>>(apiURL + query)).Where(x => x.distance > 0);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
