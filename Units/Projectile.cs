namespace angrybird_logic.Units;

using static ConsoleInterface.ConsoleInterface;

public abstract class Projectile
{
   public ConsoleInterface.ConsoleInterface? Cli { get; set; }
   private string _name;

   public abstract void IsDoingWhileShooting();
}