#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ModernMT.CLI.Commands;

internal static partial class QualityEstimationCommandApiCommand
{
    private static Option<string> Source { get; } = new(
        name: @"--source")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Target { get; } = new(
        name: @"--target")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Sentence { get; } = new(
        name: @"--sentence")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Translation { get; } = new(
        name: @"--translation")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::ModernMT.QualityEstimationResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::ModernMT.QualityEstimationResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"quality-estimation", @"Estimate translation quality");
                        command.Options.Add(Source);
                        command.Options.Add(Target);
                        command.Options.Add(Sentence);
                        command.Options.Add(Translation);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var source = parseResult.GetRequiredValue(Source);
                        var target = parseResult.GetRequiredValue(Target);
                        var sentence = parseResult.GetRequiredValue(Sentence);
                        var translation = parseResult.GetRequiredValue(Translation);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.QualityEstimationAsync(
                                    source: source,
                                    target: target,
                                    sentence: sentence,
                                    translation: translation,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::ModernMT.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}