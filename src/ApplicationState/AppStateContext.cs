using gamedev.lib.Mock;

namespace gamedev.ApplicationState;

public class AppStateContext
{
   public Session Session { get; private set; }
   public Scene Scene { get; private set; }

   public AppStateContext(Scene scene, Session session)
   {
      Scene = scene;
      Session = session;
   }
}