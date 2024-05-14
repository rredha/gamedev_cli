using View;

namespace angrybird_logic.Units;
using View;

public class Bird : Projectile
{

    public ConsoleView? Cli { get; set; }

    public override void IsDoingWhileShooting()
    {
        if (Cli == null)
        {
            return;
        }
        Cli.Print("Bird is flying");
        
    }
}