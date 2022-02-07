using System.Net.Http.Json;

using EDCalculations.APIs.EliteBgs.Models;

namespace EDCalculations.APIs.EliteBgs;

public class EBGSQueries : QueriesBase
{
    public EBGSQueries(HttpClient client) : base(client) { }

    public async Task<EBGSFactionsV5> GetFactionsAsync(string factionName)
    {
        const string apiUrl = "https://elitebgs.app/api/ebgs/v5/factions";
        string query = $"?name={Uri.EscapeDataString(factionName)}";

        try
        {
            return (await GetFromApi<Response<EBGSFactionsV5>>(apiUrl + query)).docs.First();
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}
