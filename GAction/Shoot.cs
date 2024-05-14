namespace angrybird_logic.GAction;
using View;

public class Shoot : GameAction
{

    public override void GameActionDoes()
    {
        _cli.Print("Shooting... ");
    }
}