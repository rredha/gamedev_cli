namespace angrybird_logic.Units;
using View;

public abstract class Projectile
{
   public ConsoleView? Cli { get; set; }
   public string Name { get; set; }

   public abstract void IsDoingWhileShooting();
}