using gamedev.Users.Lib;

namespace gamedev;

public interface IDatabase
{
   public bool IsAccessible { get; set; }

   public void Populate();
   public void Send(Session session);
   public void Retrieve();
}