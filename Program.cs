using angrybird_logic.GAction;
using View;

#region Scene Setup

var Scene = new ConsoleView();
var Logger = new Logger(Scene, true);
Scene.Display("Angry Bird Console App");

#endregion

#region Execution

var levelManager = new LevelManager(false, Logger);
levelManager.GetLog();
levelManager.SetState(new Level(levelManager, Scene));
#endregion

return;

