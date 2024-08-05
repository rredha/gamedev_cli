namespace View;

public class ConsoleView
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    public void Display(string message)
    {
        Console.WriteLine(message);
    }
    // Should be made static
    public string? UserInput => Console.ReadLine();
}
    /*
    public void Display(string message)
    {
        Console.WriteLine("{0}",message);
    }
    public void Display(string message0, string message1)
    {
        Console.WriteLine("{0} ,{1} ",message0, message1);
    }
    public void Display(string message0, string message1, string message2)
    {
        Console.WriteLine("{0} ,{1} ,{2} ",message0, message1, message2);
    }
   */
