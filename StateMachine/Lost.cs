namespace angrybird_logic.StateMachine;

public class Lost
{
    public static StateMachine.State state { get; set; }
    public static ConsoleInterface.ConsoleInterface? cli { get; set; }

    internal static void PlayerLost()
    {
        cli.Print("Shoot i lost again...");
        
        cli.Print("Do You want to play again ?");
        cli.Print("Type Y to restart.");
        if (cli.UserInput != "Y") return;
        
        state = StateMachine.State.LevelInit;
        Init.Level();
    }

}