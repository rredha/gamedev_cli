namespace angrybird_logic.GAction;

public class Aim : GameAction
{
    public ConsoleInterface.ConsoleInterface? _cli { set; get; }

    public override void GameActionDoes()
    {
        _cli.Print("Aim at ? ");
    }
}