using Cli.NET.Actions;
using Cli.NET.Models;
using Cli.NET.Tools;

#region Scene Setup

var container = new CommandContainer();
var commands = new CommandList
{
    { "exit", new ExitCommand() },
    { "echo", new EchoCommand() },
    { "clear", new ClearCommand() }
};

container.Display(commands);
container.Register(commands);

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


