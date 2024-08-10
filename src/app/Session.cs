namespace gamedev_cli.app;

public class Session
{
   private readonly float _id;
   private User _user;
   private IDatabase _database;

   public Session()
   {
   }
   public Session(float id, IDatabase database, User user)
   {
      _id = id;
      _database = database;
      _user = user;
   }
}