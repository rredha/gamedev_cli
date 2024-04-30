namespace angrybird_logic.Units;
using ConsoleInterface;

public class Bird : Projectile
{

    public ConsoleInterface? Cli { get; set; }

    public override void IsDoingWhileShooting()
    {
        if (Cli == null)
        {
            return;
        }
        Cli.Print("Bird is flying");
        
    }
}