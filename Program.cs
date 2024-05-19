using angrybird_logic.GameBehaviour;
using angrybird_logic.LevelState;
using View;

#region Scene Setup

var scene = new ConsoleView();
var logger = new Logger(scene, true);
scene.Display("Angry Bird Console App");

#endregion

Player mySimplePlayer = new Player(scene, 1, new KeyboardController());
IController mySimpleKeyboard = new KeyboardController();
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


