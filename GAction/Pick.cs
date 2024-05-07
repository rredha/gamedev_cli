namespace angrybird_logic.GAction;

public class Pick : GameAction
{
    public ConsoleInterface.ConsoleInterface? _cli { set; get; }

    public override void GameActionDoes()
    {
        _cli.Print("Which item to pick ? ");
    }
}