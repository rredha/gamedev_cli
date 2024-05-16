using Utils;
using View;

namespace angrybird_logic.GameState;

public class Picking : State
{
    public static ConsoleView? cli { get; set; }

    public GameStateMachine? GameStateMachine { get; }
    private void PlayerPicking()
    {
       if (Init.ProjectileUnits.Count != 0)
       {
           cli.Print(Init.ProjectileUnits.Count + " Projectiles Left");
           cli.Print("Press S to continue");
           if (cli.UserInput != "S") return;
           
           Init.ProjectileUnits.RemoveAt(Init.ProjectileUnits.Count-1);
           
           Aiming.cli = cli;
           GameStateMachine.SetState(new Aiming());
       }
       else
       {
           Lost.cli = cli;
           GameStateMachine.SetState(new Lost());
       }
    }

    public override void Start()
    {
        PlayerPicking();
    }
}