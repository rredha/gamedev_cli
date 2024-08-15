using Cli.NET.Interfaces.Actions;
using Cli.NET.Tools;

namespace gamedev_cli.app.Actions;

public class LoginCommand : ICommand
{
    private readonly CommandContainer _container;

    public LoginCommand(CommandContainer container)
    {
        _container = container;
    }

    public void Execute(string[] arguments)
    {
       Console.Clear();
       CLNConsole.WriteLine("Please enter your username", ConsoleColor.Yellow);
       //_user.Data = _user.Data with { UserName = CLNConsole.ReadText() }; 
       CLNConsole.WriteLine("Logged in successfully", ConsoleColor.Yellow);
       //_user.IsLogged = true;
       _container.WaitForNextCommand();

    }
}