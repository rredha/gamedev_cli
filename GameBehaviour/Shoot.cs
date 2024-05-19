namespace angrybird_logic.GameBehaviour;

public class Shoot : GameAction
{

    public override void GameActionDoes()
    {
        _cli.Print("Shooting... ");
    }
}