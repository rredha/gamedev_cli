namespace angrybird_logic.Units;

public class Wall : Target
{
    public override void IsDoingWhenHit()
    {
        if (isHit)
        {
            Cli.Print("Shakaboom...boom..bap.");
        }
    }

}
