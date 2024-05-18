using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Lost : State
{
    private LevelManager _levelManager;
    private ConsoleView _scene;
    public Lost(LevelManager levelManager, ConsoleView scene) : base(levelManager)
    {
        _levelManager = levelManager;
        _scene = scene;
    }

    private void PlayerLost()
    {
        _scene.Display("Shoot i lost again...");
        
        _scene.Display("Do You want to play again ?");
        _scene.Display("Type Y to restart.");
        if (_scene.UserInput != "Y") return;

        _levelManager.SetState(new Level(_levelManager,_scene));
    }

    public override void Start()
    {
        PlayerLost();
    }

}