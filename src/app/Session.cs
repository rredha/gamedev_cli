namespace gamedev_cli.app;

public class Session
{
   private readonly float _id;
   public User User;
   private Database _database;

   public Session(float id, Database database)
   {
      _id = id;
      _database = database;
   }
}