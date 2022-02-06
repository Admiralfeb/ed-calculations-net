namespace EDCalculations.APIs;

public abstract class QueriesBase
{
    private protected HttpClient Http;
    public QueriesBase(HttpClient client) => Http = client;
}
