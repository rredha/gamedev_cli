using Utils;
using View;

namespace angrybird_logic.GameState;

public class Aiming : State
{
    public Aiming(StateMachine gameStateMachine) : base(gameStateMachine)
    {
    }
    public static ConsoleView? cli { get; set; }

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
       GameStateMachine.SetState(new Shooting(GameStateMachine));
    }

}