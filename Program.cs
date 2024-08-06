using Cli.NET.Actions;
using Cli.NET.Models;
using Cli.NET.Tools;
using gamedev_cli.app.Actions;

#region Scene Setup

var container = new CommandContainer();

var coreCommands = new CommandList
{
    { "exit", new ExitCommand() },
    { "clear", new ClearCommand() }
};

var options = new CommandList
{
    {"Register", new RegisterCommand() },
    {"Login"   , new LoginCommand()    }
};
CLNConsole.WriteLine("Welcome to rehabilitation platform", ConsoleColor.Yellow);
CLNConsole.WriteLine("Please choose one of the following :", ConsoleColor.Yellow);
container.Display(options);
container.Register(coreCommands);

container.WaitForNextCommand();
#endregion

//mySimpleKeyboard.
//logger.Log(mySimplePlayer.Score.ToString());
//var controller = mySimplePlayer.Controller;
/*
#region Execution

var levelManager = new LevelManager(false, logger);
levelManager.GetLog();
levelManager.SetState(new Level(levelManager, scene));
#endregion
*/


