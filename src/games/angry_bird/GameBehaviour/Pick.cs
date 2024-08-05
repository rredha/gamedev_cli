namespace angrybird_logic.GameBehaviour;

public class Pick : GameAction
{

    //public static ConsoleView? cli { get; set; }
    public override void GameActionDoes()
    {
        _cli.Print("Which item to pick ? ");
    }
}