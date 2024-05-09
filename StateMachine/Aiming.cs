using angrybird_logic.GAction;

namespace angrybird_logic.StateMachine;

public class Aiming
{

    public static StateMachine.State state { get; set; }
    public static ConsoleInterface.ConsoleInterface? cli { get; set; }

    internal static void PlayerAiming()
    {
        cli.Print("Aiming...");
        cli.Print("Press Y to continue...");
        if (cli.UserInput != "Y")
        {
            PlayerAiming();
        }
        
        state = StateMachine.State.Shoot;
        Shooting.cli = cli;
        Shooting.PlayerShooting();
    }
}