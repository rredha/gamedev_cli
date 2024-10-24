namespace gamedev.Database;

public interface IDatabase
{
    public void Populate();

    public void Send();
    public void Retrieve();
}