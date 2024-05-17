namespace angrybird_logic.Units;

public class Pig : Unit, IDestructible, ITarget
{
    public bool IsHit(int randomValue)
    {
        return (randomValue >= 50);
    }

    public void WhenHitDo()
    {
        /*
        if (IsHit())
        {
            UnSpawn();
        }
        */
    }

    public bool IsFree(int randomValue, out int reward)
    {
        throw new NotImplementedException();
    }
}