namespace gamedev_cli.app;

public class Session
{
   private readonly float _id;
   //public User User;
   private IDatabase _database;

   public Session(float id, IDatabase database)
   {
      _id = id;
      _database = database;
   }
}