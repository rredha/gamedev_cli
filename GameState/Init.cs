using angrybird_logic.GAction;
using angrybird_logic.Units;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Init : State
{
    public static ConsoleView? cli { get; set; }
    public static GameStateMachine? gameStateMachine { get; set; }
    static int lvl = 1;
    public static List<Prisonner> PrisonnersUnits = new List<Prisonner>();
    public static List<Target> TargetUnits = new List<Target>();
    public static List<Projectile> ProjectileUnits = new List<Projectile>();
    private void Level()
    {
        cli.Print("Level : " + lvl.ToString());
        SpawnerProjectileMechanism();
        SpawnerTargetsMechanism();
        SpawnerPrisonnersMechanism();
        PromptSelection();
        
        Picking.cli = cli; 
        gameStateMachine.SetState(new Picking());
    }

    private static void SpawnProjectiles(int numberOfProjectiles)
    {
        for (var i = 0; i < numberOfProjectiles; i++)
        {
           ProjectileUnits.Add(Spawn<Bird>()); 
        }
    }

    private static void SpawnerProjectileMechanism()
    {
        SpawnProjectiles(3);
        cli.Print(ProjectileUnits.Count + " Projectiles");

    }
    private static void SpawnerTargetsMechanism()
    {
        SpawnTargets(2);
        cli.Print(TargetUnits.Count + " Walls");

    }
    private static void SpawnTargets(int numberOfTargets)
    {
        for (var i = 0; i < numberOfTargets; i++)
        {
            TargetUnits.Add(Spawn<Wall>()); 
        }
    }
    static void SpawnerPrisonnersMechanism()
    {
        SpawnPrsionners(1);
        cli.Print(PrisonnersUnits.Count + " Prisonner");


    }
    static void SpawnPrsionners(int num)
    {
        for (var i = 0; i < num; i++)
        {
            PrisonnersUnits.Add(Spawn<Prisonner>()); 
        }
    }
    private static T Spawn<T>() where T : new()
    {
        return new T();
    }

    static void PromptSelection()
    {
        List<GameAction> selectableItems = new List<GameAction>();
        var pick = new Pick();
        var aim = new Aim();
        var shoot = new Shoot();
        
        pick._cli = cli;
        aim._cli = cli;
        shoot._cli = cli;

        pick.Name = "pick";
        aim.Name = "aim";
        shoot.Name = "shoot";

        selectableItems.Add(pick);
        selectableItems.Add(aim);
        selectableItems.Add(shoot);
        
        // Sets all the options to be selectable...
        // which is not always the case.
        /*
        foreach (var gameAction in selectableItems)
        {
            gameAction.IsSelectable = true;
            gameAction.PrintSelectableGameAction(gameAction.Name);
        }
        */
        
        selectableItems[0].IsSelectable = true;
        selectableItems[1].IsSelectable = false;
        selectableItems[2].IsSelectable = false;
        
        // print selectable game actions
        foreach (var gameAction in selectableItems)
        {
            if (gameAction.IsSelectable)
            {
                gameAction.PrintSelectableGameAction(gameAction.Name);
            }
        }
        GetSelection(pick, aim, shoot);
    }

    static void GetSelection(Pick pick1, Aim aim1, Shoot shoot1)
    {

        GameAction selectedGameAction; 
        GameAction GetCurrentInput(string input) => input switch
        {
            "pick" => selectedGameAction = pick1,
            "aim" => selectedGameAction = aim1,
            "shoot" => selectedGameAction = shoot1,
            _ => throw new ArgumentOutOfRangeException("not valid"),
        };

        selectedGameAction = GetCurrentInput(cli.UserInput);
        selectedGameAction.PrintSelectedGameAction(selectedGameAction.Name);
        selectedGameAction.GameActionDoes();
    }

    public override void Start()
    {
        Level();
    }
}