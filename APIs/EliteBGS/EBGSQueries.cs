using System.Net.Http.Json;

using EDCalculations.APIs.EliteBgs.Models;

namespace EDCalculations.APIs.EDSM;

public class EBGSQueries : QueriesBase
{
    public EBGSQueries(HttpClient client) : base(client) { }

    public async Task<EBGSFactionsV5> GetFactionsAsync(string factionName)
    {
        const string apiUrl = "https://elitebgs.app/api/ebgs/v5/factions";
        string query = $"?name={Uri.EscapeDataString(factionName)}";

        var response = await Http.GetFromJsonAsync<Response<EBGSFactionsV5>>(apiUrl + query);


        if (response != null)
            return response.docs.First();
        else
            throw new Exception("Faction info is null");
    }
}
