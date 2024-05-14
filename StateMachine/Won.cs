using View;

namespace angrybird_logic.StateMachine;

public class Won
{
    public static StateMachine.State state { get; set; }
    public static ConsoleView? cli { get; set; }

    public static int lvl
    {
        get;
        set;
    }

    internal static void PlayerWon()
    {
       cli.Print("Congratulation you won");
       state = StateMachine.State.LevelInit;
       lvl++;
    }
}