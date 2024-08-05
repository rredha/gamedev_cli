using Utils;
using View;

namespace angrybird_logic.LevelState;

public class Picking : State
{
    private ConsoleView _scene;
    private LevelManager _levelManager;
    public Picking(LevelManager levelManager, ConsoleView scene) : base(levelManager)
    {
        _levelManager = levelManager;
        _scene = scene;
    }

    private void PlayerPicking()
    {
       if (Level.BirdUnits.Count != 0)
       {
           _scene.Display(Level.BirdUnits.Count + " Projectiles Left");
           _scene.Display("Press S to continue");
           if (_scene.UserInput != "S") return;
           
           Level.BirdUnits.RemoveAt(Level.BirdUnits.Count-1);
           
           _levelManager.SetState(new Aiming(_levelManager, _scene));
       }
       else
       {
           _levelManager.SetState(new Lost(_levelManager, _scene));
       }
    }

    public override void Start()
    {
        PlayerPicking();
    }

}