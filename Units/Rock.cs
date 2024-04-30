namespace angrybird_logic.Units;
using ConsoleInterface;

public class Rock : Projectile
{

    public ConsoleInterface? Cli { get; set; }

    public override void IsDoingWhileShooting()
    {
        if (Cli == null)
        {
            return;
        }
        Cli.Print("Dwayne the Rock Johnson");
        
    }
}
