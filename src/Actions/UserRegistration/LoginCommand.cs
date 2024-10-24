using Cli.NET.Interfaces.Actions;
using gamedev.lib.Mock;

namespace gamedev.Actions.UserRegistration;
public class LoginCommand : ICommand
{
    public Scene Scene { get; set; }
    public string? LastName { get; set; }

    public void Execute(string[] arguments)
    {
       Console.Clear();
       Scene.DisplayText("Enter Your Last Name", ConsoleColor.Yellow);
       LastName = Scene.GetUserInput();
       Scene.DisplayText("Verification....", ConsoleColor.Yellow);
       Scene.DisplayText("Logged in Successfully", ConsoleColor.Yellow);
    }
}
