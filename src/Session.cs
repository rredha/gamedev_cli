namespace gamedev_cli.app;

public class Session
{
   public float Id { get; private set; }
   public IDatabase? Database { get; private set; }
   public User? User { get; private set; }

   public Session()
   {
   }
   public Session(float id, IDatabase? database, User? user)
   {
      Id = id;
      Database = database;
      User = user;
   }
}