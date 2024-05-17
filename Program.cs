using angrybird_logic.GAction;
using View;
using angrybird_logic.GameState;
using angrybird_logic.Units;

var cli = new ConsoleView();
PromptWelcome(cli);

var levelManager = new LevelManager(false);
levelManager.Launch();
//Spawner mySpawner = new Spawner();
/*
#region Spawning birds
var birdUnits = new List<Unit>();
birdUnits = mySpawner.SpawnAndAddToList(new Bird(), 4);
cli.Print(birdUnits.Count.ToString());
mySpawner.UnSpawn(birdUnits);
cli.Print(birdUnits.Count.ToString());
#endregion


#region Spawning Pigs
var pigUnits = new List<Unit>();
pigUnits = mySpawner.SpawnAndAddToList(new Pig(), 3);
cli.Print(pigUnits.Count.ToString());
mySpawner.UnSpawn(pigUnits);
cli.Print(pigUnits.Count.ToString());
#endregion
*/

/*
var gameStateMachine = new GameStateMachine();
Init.cli = cli;
gameStateMachine.SetState(new Init(gameStateMachine));
*/
return;

void PromptWelcome(ConsoleView consoleInterface)
{
    consoleInterface.Print("Angry Bird Console App");
    //consoleInterface.Print("Select Action");
}
