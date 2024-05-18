using angrybird_logic.GameState;
using angrybird_logic.Units;
using Utils;
using View;
namespace angrybird_logic.GAction;

public class Level : State
{
    private int _level;
    public ConsoleView? cli { get; set; }
    private Spawner _levelSpawner = new Spawner();
    private LevelManager _levelManager;

    public Level(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
    }
    private void Initialise()
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

    private void PostInit()
    {
       _levelManager.SetState(new Picking(_levelManager)); 
    }
    public override void Start()
    {
        Initialise();
        PostInit();
    }
}