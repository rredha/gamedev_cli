using gamedev.Users.Lib;

namespace gamedev;

public static class SessionManager
{
   public static Session Create(User? user, IDatabase? database)
   {
         return new Session(1, database, user);
   }
   
   public static Session Create()
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