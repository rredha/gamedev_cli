using Utils;
using View;

namespace angrybird_logic.LevelState;

public class Won : State
{
    private ConsoleView _scene;
    private LevelManager _levelManager;
    public Won(LevelManager levelManager, ConsoleView scene) : base(levelManager)
    {
        _levelManager = levelManager;
        _scene = scene;
    }
    /*
    public static int lvl
    {
        get;
        set;
    }
    */

    private void PlayerWon()
    {
       _scene.Display("Congratulation you won");
       _levelManager.SetState(new Level(_levelManager, _scene));
      // lvl++;
    }

    public override void Start()
    {
        PlayerWon();
    }

}