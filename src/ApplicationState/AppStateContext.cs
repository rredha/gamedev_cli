using gamedev.Users.Lib;

namespace gamedev.ApplicationState;

public class AppStateContext
{
   public User User { get; private set; }
   public IDatabase Database { get; private set; }
   public Session Session { get; private set; }

   public AppStateContext(User user, IDatabase database, Session session)
   {
      User = user;
      Database = database;
      Session = session;
   }
}