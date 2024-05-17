namespace angrybird_logic.Units;
using View;

public class Bird : Unit, IProjectile, ISelectable
{

    public ConsoleView? cli { get; set; }

    public void IsDoingWhileShooting()
    {
        cli.Print("Bird is flying");
    }

    public bool IsSelectable()
    {
        return true;
    }

    public bool IsSelected(int randomValue)
    {
        const int threshold = 50;
        return randomValue >= threshold;
    }
}