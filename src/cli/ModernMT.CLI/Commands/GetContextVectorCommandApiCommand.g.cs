#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ModernMT.CLI.Commands;

internal static partial class GetContextVectorCommandApiCommand
{
    private static Option<string> Source { get; } = new(
        name: @"--source")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>> Targets { get; } = new(
        name: @"--targets")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Hints { get; } = new(
        name: @"--hints")
    {
        Description = @"",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
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

                    private static string FormatResponse(ParseResult parseResult, global::ModernMT.ContextVectorResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::ModernMT.ContextVectorResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-context-vector", @"Generate context vector for adaptive translation");
                        command.Options.Add(Source);
                        command.Options.Add(Targets);
                        command.Options.Add(Text);
                        command.Options.Add(Hints);
                        command.Options.Add(Limit);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::ModernMT.ContextVectorRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::ModernMT.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var source = parseResult.GetRequiredValue(Source);
                        var targets = parseResult.GetRequiredValue(Targets);
                        var text = parseResult.GetRequiredValue(Text);
                        var hints = CliRuntime.WasSpecified(parseResult, Hints) ? parseResult.GetValue(Hints) : (__requestBase is { } __HintsBaseValue ? __HintsBaseValue.Hints : default);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : (__requestBase is { } __LimitBaseValue ? __LimitBaseValue.Limit : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetContextVectorAsync(
                                    source: source,
                                    targets: targets,
                                    text: text,
                                    hints: hints,
                                    limit: limit,
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