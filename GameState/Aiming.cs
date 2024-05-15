using View;

namespace angrybird_logic.GameState;

public class Aiming
{

    public static GameStateMachine.State state { get; set; }
    public static ConsoleView? cli { get; set; }

    internal static void PlayerAiming()
    {
        cli.Print("Aiming...");
        cli.Print("Press Y to continue...");
        if (cli.UserInput != "Y")
        {
            PlayerAiming();
        }
        
        state = GameStateMachine.State.Shoot;
        Shooting.cli = cli;
        Shooting.PlayerShooting();
    }
}