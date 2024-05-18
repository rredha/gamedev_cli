using angrybird_logic.GAction;
using Utils;
using View;

namespace angrybird_logic.GameState;

public class Shooting : State
{
    public static ConsoleView? cli { get; set; }
    private LevelManager _levelManager;
    public Shooting(LevelManager levelManager) : base(levelManager)
    {
        _levelManager = levelManager;
    }

    private void PlayerShooting()
    {
        cli.Print("3...2..1. Shoot");
        
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
            cli.Print("You didnt hit the target");
            Picking.cli = cli;
            _levelManager.SetState(new Picking(_levelManager));
        }

        void HitSomething()
        {
            cli.Print("Target Hit !");
            Won.cli = cli;
            _levelManager.SetState(new Won(_levelManager));
        }
    }

    public override void Start()
    {
        PlayerShooting();
    }

}