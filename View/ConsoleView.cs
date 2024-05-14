namespace View;

public class ConsoleView
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    // Should be made static
    public string? UserInput => Console.ReadLine();
}
