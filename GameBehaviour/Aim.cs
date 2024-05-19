namespace angrybird_logic.GameBehaviour;

public class Aim : GameAction
{

    public override void GameActionDoes()
    {
        _cli.Print("Aim at ? ");
    }
}