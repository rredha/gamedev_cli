using Cli.NET.Interfaces.Actions;
using gamedev.lib.Mock;
using gamedev.User;
using gamedev.User.Data.Type;

namespace gamedev.Actions.UserRegistration;
public class SigninCommand : ICommand
{
    public SigninCommand(Scene scene)
    {
        Scene = scene;
    }

    private Scene Scene { get; set; }

    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? Age { get; private set; }
    public string? UserType { get; private set; }

    public void Execute(string[] arguments)
    {
        Scene.DisplayText("First Name : ", ConsoleColor.Blue);
        FirstName = Scene.GetUserInput();

        Scene.DisplayText("Last Name : ", ConsoleColor.Blue);
        LastName = Scene.GetUserInput();

        Scene.DisplayText("Age :", ConsoleColor.Blue);
        Age = Scene.GetUserInput();

        Scene.DisplayText("Your are a :", ConsoleColor.Blue);
        Scene.DisplayText("1-Patient",   ConsoleColor.Blue);
        Scene.DisplayText("2-Physicist", ConsoleColor.Blue);
        Scene.DisplayText("3-Dev",       ConsoleColor.Blue);

        switch (Scene.GetUserInput())
        {
            case "1":
                UserType = "UPatient";
                break;
            case "2":
                UserType = "UPhysicist";
                break;
            case "3":
                UserType = "UDev";
                break;
            default:
                UserType = "UDefault";
                break;
        }
        PrintSigninInfo();
        var user = UserManager.CreateUser(UserType);
        user.PersonalData = new Personal(FirstName, LastName, Age);
    }
    private void PrintSigninInfo()
    {
        Scene.DisplayText($"{LastName} {FirstName}, aged {Age}, is a {UserType}",
                            ConsoleColor.DarkGreen);

    }
}
