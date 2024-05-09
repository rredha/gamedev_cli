namespace angrybird_logic.StateMachine;

public class Shooting
{
    
    public static StateMachine.State state { get; set; }
    public static ConsoleInterface.ConsoleInterface? cli { get; set; }

    internal static void PlayerShooting()
    {
        cli.Print("3...2..1. Shoot");
        
        var rand = new Random().NextDouble();
        if (rand >= 0.8)
        {
            cli.Print("Target Hit !");
            state = StateMachine.State.Won;
            Won.cli = cli;
            Won.PlayerWon();
        }
        else
        {
            cli.Print("You didnt hit the target");
            state = StateMachine.State.Pick;
            Picking.PlayerPicking();
        }
    }
}