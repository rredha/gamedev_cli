namespace angrybird_logic.Units;
using ConsoleInterface;

public class Bomb : Projectile
{

    public ConsoleInterface? Cli { get; set; }
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
