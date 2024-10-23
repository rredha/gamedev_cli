using gamedev.User;
using gamedev.Database;

namespace gamedev;

public class Session
{
   public int Id { get; private set; }
   public IDatabase? Database { get; private set; }
   public Common User { get; private set; }

   public Session(int id, IDatabase? database, Common user)
   {
      Id = id;
      Database = database;
      User = user;
   }

   /*
   public void StoreSessionToDatabase(Session session, IDatabase database)
   {
       Database = database;
       Database.Send(this);
   }
   public void LoadSessionFromDatabase(IDatabase database)
   {
       Database = database;
       Database.Retrieve();
       IncrementSessionId(this);
   }

   private void IncrementSessionId(Session session)
   {
       session.Id++;
   }
   */
}