namespace angrybird_logic.GAction;

public class Shoot : GameAction
{
    public ConsoleInterface.ConsoleInterface? _cli { set; get; }

    public override void GameActionDoes()
    {
        _cli.Print("Shooting... ");
    }
}