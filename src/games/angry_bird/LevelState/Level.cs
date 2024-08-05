using angrybird_logic.GameBehaviour;
using angrybird_logic.Units;
using Utils;
using View;

namespace angrybird_logic.LevelState;

public class Level : State
{
    private ConsoleView _scene;
    private Spawner _levelSpawner = new Spawner();
    private LevelManager _levelManager;
    public static List<Unit> BirdUnits { get; private set; }

    public Level(LevelManager levelManager, ConsoleView scene) : base(levelManager)
    {
        _levelManager = levelManager;
        _scene = scene;

    }
    private void Initialise()
    {
        // fix the problem where all the items are added to the same list
        // push some of the logic to the spawner, where i would call the spawner to spawn stuff
        // ask the user if he wants to display or pick 
        
        _scene.Display("Sceen discription :");
        var birdUnits = new List<Unit>();
        birdUnits =_levelSpawner.SpawnAndAddToList(new Bird(), 2);
        _scene.Display(birdUnits.Count.ToString() + " Birds");
        BirdUnits = birdUnits;
        
        var pigsUnits = new List<Unit>();
        pigsUnits =_levelSpawner.SpawnAndAddToList(new Pig(), 4);
        _scene.Display(pigsUnits.Count.ToString() + " Pigs");
        
        var wallUnits = new List<Unit>();
        wallUnits =_levelSpawner.SpawnAndAddToList(new Wall(), 1);
       _scene.Display(wallUnits.Count.ToString() + " Wall");
    }

    private void PostInit()
    {
       _levelManager.SetState(new Picking(_levelManager, _scene)); 
    }
    public override void Start()
    {
        Initialise();
        PostInit();
    }
}