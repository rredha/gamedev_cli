using View;

namespace angrybird_logic.GameState;

public class Picking
{
    
    public static GameStateMachine.State state { get; set; }
    public static ConsoleView? cli { get; set; }

    internal static void PlayerPicking()
    {
       if (Init.ProjectileUnits.Count != 0)
       {
           cli.Print(Init.ProjectileUnits.Count + " Projectiles Left");
           cli.Print("Press S to continue");
           if (cli.UserInput != "S") return;
           
           Init.ProjectileUnits.RemoveAt(Init.ProjectileUnits.Count-1);
           
           state = GameStateMachine.State.Aim;
           Aiming.cli = cli;
           Aiming.PlayerAiming();
       }
       else
       {
           state = GameStateMachine.State.Lost;
           Lost.cli = cli;
           Lost.PlayerLost();
       }
    }
}