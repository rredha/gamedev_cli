namespace angrybird_logic.ConsoleInterface;

public class ConsoleInterface
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    // Should be made static
    public string? UserInput => Console.ReadLine();
}