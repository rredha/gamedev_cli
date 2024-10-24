using gamedev.lib.Mock;

namespace gamedev.ApplicationState.Stages.UserRegistration;

public class MainState : AppState
{
    public Scene Scene { get; set; }
    public Session Session { get; set; }

    public MainState(Scene scene, Session session)
    {
        Scene = scene;
        Session = session;
        Scene.DisplayText($"{GetType()}",ConsoleColor.White);
        NextState();
    }
    public override void NextState()
    {
        Session.AppState = new GameControllerState(Scene, Session);
    }
}