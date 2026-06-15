#nullable enable

using System.CommandLine;

namespace ModernMT.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(AddContentCommandApiCommand.Create());
                         command.Subcommands.Add(AddGlossaryCommandApiCommand.Create());
                         command.Subcommands.Add(CreateMemoryCommandApiCommand.Create());
                         command.Subcommands.Add(DeleteMemoryCommandApiCommand.Create());
                         command.Subcommands.Add(DetectLanguageCommandApiCommand.Create());
                         command.Subcommands.Add(GetContextVectorCommandApiCommand.Create());
                         command.Subcommands.Add(GetImportJobCommandApiCommand.Create());
                         command.Subcommands.Add(GetMemoryCommandApiCommand.Create());
                         command.Subcommands.Add(ListLanguagesCommandApiCommand.Create());
                         command.Subcommands.Add(ListMemoriesCommandApiCommand.Create());
                         command.Subcommands.Add(QualityEstimationCommandApiCommand.Create());
                         command.Subcommands.Add(TranslateCommandApiCommand.Create());
                         command.Subcommands.Add(TranslateBatchCommandApiCommand.Create());
                         command.Subcommands.Add(UpdateMemoryCommandApiCommand.Create());
        return command;
    }
}