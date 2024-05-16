using View;
using Utils;

namespace angrybird_logic.GameState;

public class Won : State
{
    public static ConsoleView? cli { get; set; }
    public static GameStateMachine? GameStateMachine { get; set; }
    public static int lvl
    {
        get;
        set;
    }

    private void PlayerWon()
    {
       cli.Print("Congratulation you won");
       Init.cli = cli;
       Init.gameStateMachine = GameStateMachine;
       GameStateMachine.SetState(new Init());
       lvl++;
    }

    public override void Start()
    {
        PlayerWon();
    }
}