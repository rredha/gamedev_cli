using gamedev.lib.Mock;

namespace gamedev.ApplicationState.Stages.GameLibrary;

public class GameControllerState : AppState
{
    public Scene Scene { get; set; }
    public Session Session { get; set; }

    public GameControllerState(Scene scene, Session session)
    {
        Scene = scene;
        Session = session;
        Scene.DisplayText($"{GetType()}",ConsoleColor.White);
        NextState();
    }
    public override void NextState()
    {
        Session.AppState = new GameLibraryState(Scene, Session);
    }
}