using UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM.Models;

namespace UnitedSystemsCooperative.Utils.EDCalc.APIs.EDSM;

public class EdsmQueries : QueriesBase
{
    public EdsmQueries(HttpClient client) : base(client)
    {
    }

    public async Task<SystemBodies> GetBodiesInSystemAsync(string systemName)
    {
        const string apiURL = ApiConstants.edsmBodies;
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        return await GetFromApi<SystemBodies>(apiURL + query);
    }

    public async Task<SystemFactionInfo> GetFactionsInSystemAsync(string systemName)
    {
        const string apiURL = ApiConstants.edsmFactions;
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        return await GetFromApi<SystemFactionInfo>(apiURL + query);
    }

    public async Task<SystemStations> GetStationsInSystemAsync(string systemName)
    {
        const string apiURL = ApiConstants.edsmStations;
        string query = $"?systemName={Uri.EscapeDataString(systemName)}";

        return await GetFromApi<SystemStations>(apiURL + query);
    }

    public async Task<IEnumerable<SphereSystem>> GetSystemsinSphereAsync(string systemName, int distance)
    {
        const string apiURL = ApiConstants.edsmSystemsinSphere;
        string query =
            $"?systemName={Uri.EscapeDataString(systemName)}&radius={distance}&showPrimaryStar=1&showInformation=1&showCoordinates=1";

        return (await GetFromApi<IEnumerable<SphereSystem>>(apiURL + query)).Where(x => x.Distance > 0);
    }
}