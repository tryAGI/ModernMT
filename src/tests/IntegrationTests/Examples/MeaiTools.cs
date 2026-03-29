/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace ModernMT.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// ModernMT provides AIFunction tools for use with any IChatClient.
    //// These tools let AI agents translate text and manage translation memories.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MODERNMT_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("MODERNMT_API_KEY environment variable is not found.");

        using var client = new ModernMTClient(apiKey);

        //// Create AIFunction tools for translation.
        var translateTool = client.AsTranslateTool();
        Assert.IsNotNull(translateTool);

        var listLanguagesTool = client.AsListLanguagesTool();
        Assert.IsNotNull(listLanguagesTool);

        var listMemoriesTool = client.AsListMemoriesTool();
        Assert.IsNotNull(listMemoriesTool);

        var detectLanguageTool = client.AsDetectLanguageTool();
        Assert.IsNotNull(detectLanguageTool);
    }
}
