using View;

namespace angrybird_logic.Units;
using View;
public abstract class Target
{
   public ConsoleView? Cli { get; set; }
   private string _name;

   public bool isHit;
   public abstract void IsDoingWhenHit();
   

}
