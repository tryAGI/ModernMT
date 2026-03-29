#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace ModernMT;

/// <summary>
/// Extensions for using ModernMTClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class ModernMTToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that translates text between languages.
    /// </summary>
    public static AIFunction AsTranslateTool(this ModernMTClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string sourceLanguage, string targetLanguage, string? hints, CancellationToken cancellationToken) =>
            {
                var response = await client.TranslateAsync(
                    new TranslateRequest
                    {
                        Q = text,
                        Source = sourceLanguage,
                        Target = targetLanguage,
                        Hints = hints,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    translation = response.Data?.Translation,
                    billed_characters = response.Data?.BilledCharacters,
                    detected_language = response.Data?.DetectedLanguage,
                });
            },
            name: "Translate",
            description: "Translates text from one language to another using ModernMT adaptive translation. Provide text, sourceLanguage (e.g., 'en'), targetLanguage (e.g., 'it'), and optional hints (comma-separated memory IDs for adaptive translation).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists supported languages.
    /// </summary>
    public static AIFunction AsListLanguagesTool(this ModernMTClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ListLanguagesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    languages = response.Data,
                });
            },
            name: "ListLanguages",
            description: "Lists all supported language codes for translation in ModernMT.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists translation memories.
    /// </summary>
    public static AIFunction AsListMemoriesTool(this ModernMTClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ListMemoriesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Data?.Select(m => new
                {
                    id = m.Id,
                    name = m.Name,
                    description = m.Description,
                }));
            },
            name: "ListMemories",
            description: "Lists all translation memories in ModernMT. Memories store bilingual content for adaptive translation.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that detects the language of text.
    /// </summary>
    public static AIFunction AsDetectLanguageTool(this ModernMTClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                var response = await client.DetectLanguageAsync(
                    new DetectLanguageRequest
                    {
                        Q = text,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    detected_language = response.Data?.DetectedLanguage,
                });
            },
            name: "DetectLanguage",
            description: "Detects the language of the provided text using ModernMT.");
    }
}
