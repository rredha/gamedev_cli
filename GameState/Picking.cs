using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Picking : State
{
    public static ConsoleView? cli { get; set; }
    private LevelManager _levelManager;
    public Picking(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
    }

    private void PlayerPicking()
    {
       if (Level.BirdUnits.Count != 0)
       {
           cli.Print(Level.BirdUnits.Count + " Projectiles Left");
           cli.Print("Press S to continue");
           if (cli.UserInput != "S") return;
           
           Level.BirdUnits.RemoveAt(Level.BirdUnits.Count-1);
           
           Aiming.cli = cli;
           _levelManager.SetState(new Aiming(_levelManager));
       }
       else
       {
           Lost.cli = cli;
           _levelManager.SetState(new Lost(_levelManager));
       }
    }

    public override void Start()
    {
        PlayerPicking();
    }

}