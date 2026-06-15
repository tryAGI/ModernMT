#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ModernMT.CLI.Commands;

internal static partial class TranslateBatchCommandApiCommand
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

    private static Option<global::System.Collections.Generic.IList<string>> Q { get; } = new(
        name: @"--q")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Webhook { get; } = new(
        name: @"--webhook")
    {
        Description = @"Webhook URL for batch completion callback",
        Required = true,
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"Optional metadata passed through to webhook",
    };

    private static Option<string?> Hints { get; } = new(
        name: @"--hints")
    {
        Description = @"",
    };

    private static Option<global::ModernMT.BatchTranslateRequestPriority?> Priority { get; } = new(
        name: @"--priority")
    {
        Description = @"",
    };
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

                    private static string FormatResponse(ParseResult parseResult, global::ModernMT.BatchTranslateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::ModernMT.BatchTranslateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"translate-batch", @"Submit batch translation");
                        command.Options.Add(Source);
                        command.Options.Add(Target);
                        command.Options.Add(Q);
                        command.Options.Add(Webhook);
                        command.Options.Add(Metadata);
                        command.Options.Add(Hints);
                        command.Options.Add(Priority);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::ModernMT.BatchTranslateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::ModernMT.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var source = parseResult.GetRequiredValue(Source);
                        var target = parseResult.GetRequiredValue(Target);
                        var q = parseResult.GetRequiredValue(Q);
                        var webhook = parseResult.GetRequiredValue(Webhook);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var hints = CliRuntime.WasSpecified(parseResult, Hints) ? parseResult.GetValue(Hints) : (__requestBase is { } __HintsBaseValue ? __HintsBaseValue.Hints : default);
                        var priority = CliRuntime.WasSpecified(parseResult, Priority) ? parseResult.GetValue(Priority) : (__requestBase is { } __PriorityBaseValue ? __PriorityBaseValue.Priority : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TranslateBatchAsync(
                                    source: source,
                                    target: target,
                                    q: q,
                                    webhook: webhook,
                                    metadata: metadata,
                                    hints: hints,
                                    priority: priority,
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