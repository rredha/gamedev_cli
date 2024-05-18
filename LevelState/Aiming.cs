using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Aiming : State
{
    private LevelManager _levelManager;
    private ConsoleView _scene; 
    public Aiming(LevelManager levelManager, ConsoleView scene) : base(levelManager)
    {
        _levelManager = levelManager;
        _scene = scene;
    }

    private void PlayerAiming()
    {
        _scene.Display("Aiming...");
        _scene.Display("Press Y to continue...");
        if (_scene.UserInput != "Y")
        {
            PlayerAiming();
        }
    }

    public override void Start()
    {
       PlayerAiming(); 
       
       _levelManager.SetState(new Shooting(_levelManager, _scene));
    }

}