using View;

namespace angrybird_logic.GameBehaviour;

public class Player
{
    // this should be comming from the controller.

    public Player(ConsoleView scene,int playerId ,IController controller)
    {
        Controller = controller;
        PlayerId = playerId;
        Scene = scene;
    }
    public IController Controller;
    public int PlayerId {get; private set; }
    private ConsoleView Scene;

    public int Score { get; private set; }


}