using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Moq;
using Moq.Protected;

namespace EDCalculations.APIs.Test;

internal static class MockClient
{
    internal static HttpClient GenerateMockClientWithData(string jsonValue)
    {
        HttpResponseMessage httpResponse = new HttpResponseMessage();
        httpResponse.StatusCode = System.Net.HttpStatusCode.OK;
        httpResponse.Content = new StringContent(jsonValue, Encoding.UTF8, "application/json");

        Mock<HttpMessageHandler> mockHandler = new();
        mockHandler.Protected()
        .Setup<Task<HttpResponseMessage>>("SendAsync",
        ItExpr.IsAny<HttpRequestMessage>(),
        ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(httpResponse);

        HttpClient httpClient = new(mockHandler.Object);

        return httpClient;
    }

    internal static HttpClient GenerateMockClientWithNull()
    {
        HttpResponseMessage httpResponse = new HttpResponseMessage();
        httpResponse.StatusCode = System.Net.HttpStatusCode.OK;
        httpResponse.Content = null;

        Mock<HttpMessageHandler> mockHandler = new();
        mockHandler.Protected()
        .Setup<Task<HttpResponseMessage>>("SendAsync",
        ItExpr.IsAny<HttpRequestMessage>(),
        ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(httpResponse);

        HttpClient httpClient = new(mockHandler.Object);

        return httpClient;
    }

    internal static HttpClient GenerateMockClientWithError()
    {
        HttpResponseMessage httpResponse = new HttpResponseMessage();
        httpResponse.StatusCode = System.Net.HttpStatusCode.NotFound;

        Mock<HttpMessageHandler> mockHandler = new();
        mockHandler.Protected()
        .Setup<Task<HttpResponseMessage>>("SendAsync",
        ItExpr.IsAny<HttpRequestMessage>(),
        ItExpr.IsAny<CancellationToken>())
        .ReturnsAsync(httpResponse);

        HttpClient httpClient = new(mockHandler.Object);

        return httpClient;
    }
}
