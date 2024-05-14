namespace angrybird_logic.Units;
using View;

public class Rock : Projectile
{

    public ConsoleView? Cli { get; set; }

    public override void IsDoingWhileShooting()
    {
        if (Cli == null)
        {
            return;
        }
        Cli.Print("Dwayne the Rock Johnson");
        
    }
}
