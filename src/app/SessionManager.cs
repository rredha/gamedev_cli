using System.ComponentModel.DataAnnotations.Schema;

namespace gamedev_cli.app;

public static class SessionManager
{

   public static Session Create(IDatabase database, User user)
   {
         return new Session(1, database, user);
   }
   
   public static Session Create(Session database)
   {
      return new Session();
   }

   public static void Load(Session session)
   {
      throw new NotImplementedException();
   }
   
   public static void Launch(Session session)
   {
      throw new NotImplementedException();
   }
   
   public static void Quit()
   {
      throw new NotImplementedException();
   }
}