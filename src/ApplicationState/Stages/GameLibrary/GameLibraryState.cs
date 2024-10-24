using gamedev.ApplicationState.Stages.External;
using gamedev.ApplicationState.Stages.UserRegistration;
using gamedev.lib.Mock;

namespace gamedev.ApplicationState.Stages.GameLibrary;

public class GameLibraryState : AppState
{
    public Scene Scene { get; set; }
    public Session Session { get; set; }

    public GameLibraryState(Scene scene, Session session)
    {
        Scene = scene;
        Session = session;
        Scene.DisplayText($"{GetType()}",ConsoleColor.White);
        NextState();
    }
    public override void NextState()
    {
        Session.AppState = new GameState(Scene, Session);
    }
}