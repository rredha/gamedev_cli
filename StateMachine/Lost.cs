namespace angrybird_logic.StateMachine;

public class Lost
{
    public static StateMachine.State state { get; set; }
    public static ConsoleInterface.ConsoleInterface? cli { get; set; }

    internal static void PlayerLost()
    {
        cli.Print("Shoot i lost again...");
        state = StateMachine.State.LevelInit;
    }

}