using Utils;
using View;

namespace angrybird_logic.GameState;

public class Lost : State
{
    public static ConsoleView? cli { get; set; }

    public GameStateMachine? GameStateMachine { get; }
    private void PlayerLost()
    {
        cli.Print("Shoot i lost again...");
        
        cli.Print("Do You want to play again ?");
        cli.Print("Type Y to restart.");
        if (cli.UserInput != "Y") return;

        Init.cli = cli;
        GameStateMachine.SetState(new Init());
    }

    public override void Start()
    {
        PlayerLost();
    }
}