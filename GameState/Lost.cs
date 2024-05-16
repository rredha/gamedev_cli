using Utils;
using View;

namespace angrybird_logic.GameState;

public class Lost : State
{
    public Lost(StateMachine gameStateMachine) : base(gameStateMachine)
    {
    }
    public static ConsoleView? cli { get; set; }

    private void PlayerLost()
    {
        cli.Print("Shoot i lost again...");
        
        cli.Print("Do You want to play again ?");
        cli.Print("Type Y to restart.");
        if (cli.UserInput != "Y") return;

        Init.cli = cli;
        GameStateMachine.SetState(new Init(GameStateMachine));
    }

    public override void Start()
    {
        PlayerLost();
    }

}