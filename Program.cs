using angrybird_logic.GAction;
using View;

var cli = new ConsoleView();
PromptWelcome(cli);

var levelManager = new LevelManager(false, cli);
Level.cli = cli;
levelManager.SetState(new Level(levelManager));

return;

void PromptWelcome(ConsoleView consoleInterface)
{
    consoleInterface.Print("Angry Bird Console App");
    //consoleInterface.Print("Select Action");
}
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
