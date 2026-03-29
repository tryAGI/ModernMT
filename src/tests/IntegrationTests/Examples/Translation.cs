/* order: 10, title: Translation, slug: translation */

namespace ModernMT.IntegrationTests.Examples;

[TestClass]
public class Translation
{
    //// ModernMT provides adaptive machine translation with translation memories.
    //// Create a client and access the translation API.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MODERNMT_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("MODERNMT_API_KEY environment variable is not found.");

        using var client = new ModernMTClient(apiKey);

        //// The client provides access to translation, memories, and language detection.
        Assert.IsNotNull(client);
    }
}
