#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace ModernMT.CLI.Commands;

internal static partial class AddGlossaryCommandApiCommand
{
    private static Argument<int> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<global::ModernMT.AddGlossaryRequestType> Type { get; } = new(
        name: @"--type")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> Tuid { get; } = new(
        name: @"--tuid")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::ModernMT.AddGlossaryRequestTerm>> Terms { get; } = new(
        name: @"--terms")
    {
        Description = @"",
        Required = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::ModernMT.ImportJobResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::ModernMT.ImportJobResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"add-glossary", @"Add glossary terms to a memory");
                        command.Arguments.Add(Id);
                        command.Options.Add(Type);
                        command.Options.Add(Tuid);
                        command.Options.Add(Terms);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::ModernMT.AddGlossaryRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::ModernMT.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var type = parseResult.GetRequiredValue(Type);
                        var tuid = CliRuntime.WasSpecified(parseResult, Tuid) ? parseResult.GetValue(Tuid) : (__requestBase is { } __TuidBaseValue ? __TuidBaseValue.Tuid : default);
                        var terms = parseResult.GetRequiredValue(Terms);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AddGlossaryAsync(
                                    id: id,
                                    type: type,
                                    tuid: tuid,
                                    terms: terms,
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