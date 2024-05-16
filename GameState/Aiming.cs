using Utils;
using View;

namespace angrybird_logic.GameState;

public class Aiming : State
{
    public static ConsoleView? cli { get; set; }

    public GameStateMachine? GameStateMachine { get; }
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
       GameStateMachine.SetState(new Shooting());
    }
}