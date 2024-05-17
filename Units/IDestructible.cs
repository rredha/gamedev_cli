namespace angrybird_logic.Units;

public interface IDestructible
{
    public bool IsHit(int randomValue);

    public void WhenHitDo();

}