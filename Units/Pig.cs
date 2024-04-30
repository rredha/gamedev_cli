namespace angrybird_logic.Units;

public class Pig : Target
{
    public override void IsDoingWhenHit()
    {
        if (isHit)
        {
            Cli.Print("Shoot i've been hit...");
        }
    }

}