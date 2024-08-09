using Cli.NET.Interfaces.Actions;
using Cli.NET.Tools;

namespace gamedev_cli.app.Actions;

public class LoginCommand : ICommand
{
    private readonly CommandContainer _container;
    private  UserData userData { get; private set; }
    private  UserType userType { get; private set; }
    private User user = new User(userDate, userType );

    public LoginCommand(CommandContainer container)
    {
        _container = container;
    }

    public void Execute(string[] arguments)
    {
       Console.Clear();
       CLNConsole.WriteLine("Please your username", ConsoleColor.Yellow);
       _unLoggedUser.Data = _unLoggedUser.Data with { UserName = CLNConsole.ReadText() }; 
       CLNConsole.WriteLine("Logged in successfully", ConsoleColor.Yellow);
       
       _container.WaitForNextCommand();

    }
}