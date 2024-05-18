using angrybird_logic.GameState;
using angrybird_logic.Units;
using Utils;
using View;
namespace angrybird_logic.GAction;

public class Level : State
{
    private int _level;
    public static ConsoleView? cli { get; set; }
    private Spawner _levelSpawner = new Spawner();
    private LevelManager _levelManager;
    public static List<Unit> BirdUnits { get; private set; }

    public Level(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
    }
    private void Initialise()
    {
        cli.Print("Setting Level, current Level " + _level.ToString());
        cli.Print("Sceen discription :");
        var birdUnits = new List<Unit>();
        birdUnits =_levelSpawner.SpawnAndAddToList(new Bird(), 3);
        cli.Print(birdUnits.Count.ToString() + " Birds");
        BirdUnits = birdUnits;
        
        var pigsUnits = new List<Unit>();
        pigsUnits =_levelSpawner.SpawnAndAddToList(new Pig(), 4);
        cli.Print(pigsUnits.Count.ToString() + " Pigs");
        
        var wallUnits = new List<Unit>();
        wallUnits =_levelSpawner.SpawnAndAddToList(new Wall(), 1);
        cli.Print(wallUnits.Count.ToString() + " Wall");
    }

    private void PostInit()
    {
        Picking.cli = cli;
       _levelManager.SetState(new Picking(_levelManager)); 
    }
    public override void Start()
    {
        Initialise();
        PostInit();
    }
}