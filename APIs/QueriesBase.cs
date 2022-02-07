using System.Net.Http.Json;

namespace EDCalculations.APIs;

public abstract class QueriesBase
{
    private protected HttpClient Http;
    public QueriesBase(HttpClient client) => Http = client;

    private protected async Task<T> GetFromApi<T>(string url)
    {
        T? response = await Http.GetFromJsonAsync<T>(url);

        if (response != null)
            return response;
        else
            throw new NullReferenceException("Bodies is null");
    }
}
