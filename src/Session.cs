namespace gamedev;

/*
public class Session
{
   public int Id { get; private set; }
   public IDatabase? Database { get; private set; }
   public User.Lib.User? User { get; private set; }

   public Session(int id, IDatabase? database, User.Lib.User? user)
   {
      Id = id;
      Database = database;
      User = user;
   }

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
}
*/