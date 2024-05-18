using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Lost : State
{
    private LevelManager _levelManager;
    public Lost(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
    }
    public static ConsoleView? cli { get; set; }

    private void PlayerLost()
    {
        cli.Print("Shoot i lost again...");
        
        cli.Print("Do You want to play again ?");
        cli.Print("Type Y to restart.");
        if (cli.UserInput != "Y") return;

        Init.cli = cli;
        _levelManager.SetState(new Level(_levelManager));
    }

    public override void Start()
    {
        PlayerLost();
    }

}