namespace ModernMT.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ModernMTClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MODERNMT_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MODERNMT_API_KEY environment variable is not found.");

        var client = new ModernMTClient(apiKey);
        
        return client;
    }
}
