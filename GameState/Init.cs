using angrybird_logic.GAction;
using angrybird_logic.Units;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Init : State
{
    public Init(StateMachine gameStateMachine) : base(gameStateMachine)
    {
    }
    public static ConsoleView? cli { get; set; }
    static int lvl = 1;
//    public List<Prisonner> PrisonnersUnits = new List<Prisonner>();
 //   public List<Target> TargetUnits = new List<Target>();
  //  public List<Projectile> ProjectileUnits = new List<Projectile>();


    private void Level()
    {
        cli.Print("Level : " + lvl.ToString());
    //    Spawner.SpawnerProjectileMechanism();
    //    Spawner.SpawnerTargetsMechanism();
    //    Spawner.SpawnerPrisonnersMechanism();
        PromptSelection();
        
        Picking.cli = cli; 
        GameStateMachine.SetState(new Picking(GameStateMachine));
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