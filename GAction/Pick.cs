namespace angrybird_logic.GAction;
using View;

public class Pick : GameAction
{

    //public static ConsoleView? cli { get; set; }
    public override void GameActionDoes()
    {
        _cli.Print("Which item to pick ? ");
    }
}