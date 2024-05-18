using angrybird_logic.GAction;
using View;
using Utils;

namespace angrybird_logic.GameState;

public class Won : State
{
    public static ConsoleView? cli { get; set; }
    private LevelManager _levelManager;
    public Won(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
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
       _levelManager.SetState(new Level(_levelManager));
       lvl++;
    }

    public override void Start()
    {
        PlayerWon();
    }

}