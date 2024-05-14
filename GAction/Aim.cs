namespace angrybird_logic.GAction;
using View;

public class Aim : GameAction
{

    public override void GameActionDoes()
    {
        _cli.Print("Aim at ? ");
    }
}