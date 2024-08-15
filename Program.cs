using Cli.NET.Actions;
using Cli.NET.Models;
using Cli.NET.Tools;
using gamedev_cli.app.Actions;
using gamedev_cli.app;

#region Scene Setup

var container = new CommandContainer();

var coreCommands = new CommandList
{
    { "exit", new ExitCommand() },
    { "clear", new ClearCommand() }
};

var options = new CommandList
{
    {"Register", new RegisterCommand(container) },
    {"Login"   , new LoginCommand( container)   }
};
CLNConsole.WriteLine("Welcome to rehabilitation platform", ConsoleColor.Yellow);
CLNConsole.WriteLine("Please choose one of the following :", ConsoleColor.Yellow);
container.Display(options);

container.Register(options);
container.Register(coreCommands);

User user = new User(UserType.Unset);

container.WaitForNextCommand();
#endregion
