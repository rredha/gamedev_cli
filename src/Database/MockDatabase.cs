namespace gamedev.Database;

public class MockDatabase : IDatabase
{
    //public bool IsAccessible { get; set; }
    public void Populate()
    {
        Console.WriteLine("Population Database");
    }

    public void Send()
    {
        Console.WriteLine("Sending data to database");
    }

    public void Retrieve()
    {
        Console.WriteLine("Retrieving data from database");
    }
}