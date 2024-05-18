using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Aiming : State
{
    public static ConsoleView? cli { get; set; }
    private LevelManager _levelManager;
    public Aiming(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
    }

    private void PlayerAiming()
    {
        cli.Print("Aiming...");
        cli.Print("Press Y to continue...");
        if (cli.UserInput != "Y")
        {
            PlayerAiming();
        }
    }

    public override void Start()
    {
       PlayerAiming(); 
       
       Shooting.cli = cli;
       _levelManager.SetState(new Shooting(_levelManager));
    }

}