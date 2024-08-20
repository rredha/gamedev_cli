using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Interfaces;
using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Models;
using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Tools;

namespace gamedev.Actions;

public class RegisterCommand : ICommand
{
    private readonly CommandContainer _container;
    public RegisterCommand(CommandContainer container)
    {
        _container = container;
    }
    private readonly CommandList _options = new CommandList
    {
        { "Patient", new ChoosePatientCommand() },
        { "Physician", new ChoosePhysicianCommand() },
        { "Dev", new ChooseDevCommand() }
    };


    public void Execute(string[] arguments)
    {
       Console.Clear();
       CLNConsole.WriteLine("Please choose a user category.", ConsoleColor.Yellow);
       _container.Display(_options);
       _container.Register(_options);
       
       _container.WaitForNextCommand();
    }
}