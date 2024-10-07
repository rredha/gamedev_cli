using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Actions;
using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Models;
using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Tools;

namespace gamedev.lib.Mock;

public class Scene
{
    public CommandContainer Container { get; private set; }

    public Scene()
    {
        Container = new CommandContainer();
    }

    
    public CommandList CoreOption(CommandContainer container)
    {
        CommandList coreCommands = new CommandList
        {
            { "exit", new ExitCommand() },
            { "clear", new ClearCommand() }
        };
        container.Register(coreCommands);
        return coreCommands;
    }

    

    public void DisplayText(string text, ConsoleColor color)
    {
        CLNConsole.WriteLine(text, color);
    }

    public void Options(CommandList options)
    {
        Container.Display(options);
    }

    public string? GetUserInput()
    {
       return CLNConsole.ReadText();
    }

    /*
    public string GetUserData(User.Lib.User user)
    {
        return string.Format("Welcome {0} {1}\n Age : {2}",
            user.Data.FirstName,
            user.Data.LastName,
            user.Data.Age);
    }
    public string GetUserStatus(User.Lib.User user)
    {
        return user.Type.ToString();
    }
    */
    public void WaitForUserInput()
    {
        CLNConsole.ReadText();
    }
    
    public void WaitForUserCommand()
    {
        Container.WaitForNextCommand();
    }
        
}