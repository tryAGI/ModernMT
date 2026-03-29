# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The ModernMT SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models adaptive machine translation, language detection, and translation memory management.

## Installation

```bash
dotnet add package tryAGI.ModernMT
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTranslateTool()` | `Translate` | Translate text between languages |
| `AsListLanguagesTool()` | `ListLanguages` | List supported language codes |
| `AsListMemoriesTool()` | `ListMemories` | List translation memories |
| `AsDetectLanguageTool()` | `DetectLanguage` | Detect language of text |

## Usage

```csharp
using Microsoft.Extensions.AI;
using ModernMT;

var client = new ModernMTClient(
    apiKey: Environment.GetEnvironmentVariable("MODERNMT_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsTranslateTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Translate 'Hello, how are you?' to French"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
