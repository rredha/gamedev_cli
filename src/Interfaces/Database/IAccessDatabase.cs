namespace gamedev;

public interface IAccessDatabase
{
   public bool IsAccessible { get; set; }

   public void Populate();
   //public void Send(Session session);
   public void Retrieve();
}