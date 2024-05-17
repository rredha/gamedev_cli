using angrybird_logic.Units;
using View;
namespace angrybird_logic.GAction;

public class Level
{
    private int _level;
    ConsoleView cli = new ConsoleView();
    private Spawner _levelSpawner = new Spawner();
    public Level(int level)
    {
        _level = level;
    }
    public void Initialise()
    {
        cli.Print("Hello i'm setting myself up....");
        cli.Print("current level is " + _level.ToString());
        var birdUnits = new List<Unit>();
        birdUnits =_levelSpawner.SpawnAndAddToList(new Bird(), 3);
        cli.Print(birdUnits.Count.ToString() + " Birds");
        
        var pigsUnits = new List<Unit>();
        pigsUnits =_levelSpawner.SpawnAndAddToList(new Pig(), 4);
        cli.Print(pigsUnits.Count.ToString() + " Pigs");
        
        var wallUnits = new List<Unit>();
        wallUnits =_levelSpawner.SpawnAndAddToList(new Wall(), 1);
        cli.Print(wallUnits.Count.ToString() + " Wall");
    }

}