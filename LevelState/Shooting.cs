using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.LevelState;

public class Shooting : State
{
    private LevelManager _levelManager;
    private  ConsoleView _scene;

    public Shooting(LevelManager levelManager, ConsoleView scene) : base(levelManager)
    {
        _levelManager = levelManager;
        _scene = scene;
    }

    private void PlayerShooting()
    {
        _scene.Display("3...2..1. Shoot");
        
        var rand = new Random().NextDouble();
        if (rand >= 0.8)
        {
            HitSomething();
        }
        else
        {
            NothingHit();
        }

        void NothingHit()
        {
            _scene.Display("You didnt hit the target");
            _levelManager.SetState(new Picking(_levelManager, _scene));
        }

        void HitSomething()
        {
            _scene.Display("Target Hit !");
            _levelManager.SetState(new Won(_levelManager, _scene));
        }
    }

    public override void Start()
    {
        PlayerShooting();
    }

}