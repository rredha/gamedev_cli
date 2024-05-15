using View;

namespace angrybird_logic.GameState;

public class Lost
{
    public static GameStateMachine.State state { get; set; }
    public static ConsoleView? cli { get; set; }

    internal static void PlayerLost()
    {
        cli.Print("Shoot i lost again...");
        
        cli.Print("Do You want to play again ?");
        cli.Print("Type Y to restart.");
        if (cli.UserInput != "Y") return;
        
        state = GameStateMachine.State.LevelInit;
        Init.Level();
    }

}