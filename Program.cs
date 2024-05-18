using angrybird_logic.LevelState;
using View;

#region Scene Setup

var scene = new ConsoleView();
var logger = new Logger(scene, true);
scene.Display("Angry Bird Console App");

#endregion

#region Execution

var levelManager = new LevelManager(false, logger);
levelManager.GetLog();
levelManager.SetState(new Level(levelManager, scene));
#endregion


