namespace angrybird_logic.Units;
using View;

public interface IPrisonner
{
    public ConsoleView? Cli { get; set; }
    public bool SetFree();

    public void WhenFree(bool isFree);

}