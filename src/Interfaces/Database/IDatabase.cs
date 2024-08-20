using gamedev.Users.Lib;

namespace gamedev;

public interface IDatabase
{
   public bool IsAccessible { get; set; }

   public void Populate();
   public void Send(User user);
   public void Retrieve();
}