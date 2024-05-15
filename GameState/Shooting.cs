using View;

namespace angrybird_logic.GameState;

public class Shooting
{
    
    public static GameStateMachine.State state { get; set; }
    public static ConsoleView? cli { get; set; }

    internal static void PlayerShooting()
    {
        cli.Print("3...2..1. Shoot");
        
        var rand = new Random().NextDouble();
        if (rand >= 0.8)
        {
            cli.Print("Target Hit !");
            state = GameStateMachine.State.Won;
            Won.cli = cli;
            Won.PlayerWon();
        }
        else
        {
            cli.Print("You didnt hit the target");
            state = GameStateMachine.State.Pick;
            Picking.PlayerPicking();
        }
    }
}