namespace angrybird_logic.Units;

public class Wall : Unit, IDestructible
{
    private bool _isHit = false;
    public bool IsHit(int randomValue)
    {
        return _isHit = (randomValue >= 30);
    }

    public void WhenHitDo()
    {
        if (_isHit)
        {
           // text that it beign distroyed
           // unspawn
           // describe current scene.
        }
    }
}
