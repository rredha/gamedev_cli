using angrybird_logic.Units;

namespace angrybird_logic.StateMachine;

public class Picking
{
    
    public static StateMachine.State state { get; set; }
    public static ConsoleInterface.ConsoleInterface? cli { get; set; }

    internal static void PlayerPicking()
    {
       if (Init.ProjectileUnits.Count != 0)
       {
           cli.Print(Init.ProjectileUnits.Count + " Projectiles Left");
           cli.Print("Press S to continue");
           if (cli.UserInput != "S") return;
           
           Init.ProjectileUnits.RemoveAt(Init.ProjectileUnits.Count-1);
           
           state = StateMachine.State.Aim;
           Aiming.cli = cli;
           Aiming.PlayerAiming();
       }
       else
       {
           state = StateMachine.State.Lost;
           Lost.cli = cli;
           Lost.PlayerLost();
       }
    }
}