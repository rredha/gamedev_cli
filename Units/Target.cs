namespace angrybird_logic.Units;
using static ConsoleInterface.ConsoleInterface;

public abstract class Target
{
   public ConsoleInterface.ConsoleInterface? Cli { get; set; }
   private string _name;

   public bool isHit;
   public abstract void IsDoingWhenHit();
   

}
