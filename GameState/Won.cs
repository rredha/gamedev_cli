using View;
using Utils;

namespace angrybird_logic.GameState;

public class Won : State
{
    public static ConsoleView? cli { get; set; }
    public Won(StateMachine gameStateMachine) : base(gameStateMachine)
    {
    }
    public static int lvl
    {
        get;
        set;
    }

    private void PlayerWon()
    {
       cli.Print("Congratulation you won");
       Init.cli = cli;
       GameStateMachine.SetState(new Init(GameStateMachine));
       lvl++;
    }

    public override void Start()
    {
        PlayerWon();
    }

}