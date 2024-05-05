namespace angrybird_logic.ConsoleInterface;

public class ConsoleInterface
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    public string? UserInput => Console.ReadLine();
}