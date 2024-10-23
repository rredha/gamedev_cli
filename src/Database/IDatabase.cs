namespace gamedev.Database;

public interface IDatabase
{
    public void Populate();

    public void Send(Session session);

    public void Retrieve();
}