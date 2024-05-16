using Utils;
using View;

namespace angrybird_logic.GameState;

public class Shooting : State
{
    public static ConsoleView? cli { get; set; }
    public Shooting(StateMachine gameStateMachine) : base(gameStateMachine)
    {
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
            GameStateMachine.SetState(new Picking(GameStateMachine));
        }

        void HitSomething()
        {
            cli.Print("Target Hit !");
            Won.cli = cli;
            GameStateMachine.SetState(new Won(GameStateMachine));
        }
    }

    public override void Start()
    {
        PlayerShooting();
    }

}