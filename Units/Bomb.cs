namespace angrybird_logic.Units;
using View;

public class Bomb : Projectile
{

    public ConsoleView? Cli { get; set; }
    public string Name = "Bomb";
    public override void IsDoingWhileShooting()
    {
        if (Cli == null)
        {
            return;
        }
        Cli.Print("Pshhhh Boom !");
        
    }
}
