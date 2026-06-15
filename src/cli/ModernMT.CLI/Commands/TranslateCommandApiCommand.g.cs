#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ModernMT.CLI.Commands;

internal static partial class TranslateCommandApiCommand
{
    private static Option<string> Source { get; } = new(
        name: @"--source")
    {
        Description = @"Source language code (e.g., ""en"")",
        Required = true,
    };

    private static Option<string> Target { get; } = new(
        name: @"--target")
    {
        Description = @"Target language code (e.g., ""it"")",
        Required = true,
    };

    private static Option<string> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Text to translate",
        Required = true,
    };

    private static Option<string?> Hints { get; } = new(
        name: @"--hints")
    {
        Description = @"Comma-separated memory IDs for adaptive translation",
    };

    private static Option<global::ModernMT.TranslateRequestPriority?> Priority { get; } = new(
        name: @"--priority")
    {
        Description = @"Translation priority",
    };

    private static Option<bool?> Multiline { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--multiline",
        description: @"Whether to treat the text as multiline");

    private static Option<global::ModernMT.TranslateRequestFormat?> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Text format",
    };

    private static Option<int?> AltTranslations { get; } = new(
        name: @"--alt-translations")
    {
        Description = @"Number of alternative translations to return",
    };

    private static Option<bool?> MaskProfanities { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--mask-profanities",
        description: @"Whether to mask profanities");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::ModernMT.TranslateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::ModernMT.TranslateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"translate", @"Translate text");
                        command.Options.Add(Source);
                        command.Options.Add(Target);
                        command.Options.Add(Q);
                        command.Options.Add(Hints);
                        command.Options.Add(Priority);
                        command.Options.Add(Multiline);
                        command.Options.Add(Format);
                        command.Options.Add(AltTranslations);
                        command.Options.Add(MaskProfanities);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::ModernMT.TranslateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::ModernMT.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var source = parseResult.GetRequiredValue(Source);
                        var target = parseResult.GetRequiredValue(Target);
                        var q = parseResult.GetRequiredValue(Q);
                        var hints = CliRuntime.WasSpecified(parseResult, Hints) ? parseResult.GetValue(Hints) : __requestBase is not null ? __requestBase.Hints : default;
                        var priority = CliRuntime.WasSpecified(parseResult, Priority) ? parseResult.GetValue(Priority) : __requestBase is not null ? __requestBase.Priority : default;
                        var multiline = CliRuntime.WasSpecified(parseResult, Multiline) ? parseResult.GetValue(Multiline) : __requestBase is not null ? __requestBase.Multiline : default;
                        var format = CliRuntime.WasSpecified(parseResult, Format) ? parseResult.GetValue(Format) : __requestBase is not null ? __requestBase.Format : default;
                        var altTranslations = CliRuntime.WasSpecified(parseResult, AltTranslations) ? parseResult.GetValue(AltTranslations) : __requestBase is not null ? __requestBase.AltTranslations : default;
                        var maskProfanities = CliRuntime.WasSpecified(parseResult, MaskProfanities) ? parseResult.GetValue(MaskProfanities) : __requestBase is not null ? __requestBase.MaskProfanities : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TranslateAsync(
                                    source: source,
                                    target: target,
                                    q: q,
                                    hints: hints,
                                    priority: priority,
                                    multiline: multiline,
                                    format: format,
                                    altTranslations: altTranslations,
                                    maskProfanities: maskProfanities,
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