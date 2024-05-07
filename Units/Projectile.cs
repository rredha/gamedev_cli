namespace angrybird_logic.Units;

using static ConsoleInterface.ConsoleInterface;

public abstract class Projectile
{
   public ConsoleInterface.ConsoleInterface? Cli { get; set; }
   public string Name { get; set; }

   public abstract void IsDoingWhileShooting();
}