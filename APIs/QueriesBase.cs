using System.Net.Http.Json;

namespace EDCalculations.APIs;

public abstract class QueriesBase
{
    private protected HttpClient Http;
    protected QueriesBase(HttpClient client) => Http = client;

    private protected async Task<T> GetFromApi<T>(string url)
    {
        T? response = await Http.GetFromJsonAsync<T>(url);

        if (response == null)
            throw new NullDataException($"Data from '{url}' is null");

        return response;
    }
}
