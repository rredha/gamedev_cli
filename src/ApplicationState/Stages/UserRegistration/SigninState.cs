using Cli.NET.Interfaces.Actions;
using gamedev.lib.Mock;

namespace gamedev.ApplicationState.Stages.UserRegistration;

public class SigninState : AppState, ICommand
{
    public Scene Scene { get; set; }
    public Session Session { get; set; }

    public SigninState(Scene scene, Session session)
    {
        Scene = scene;
        Session = session;
        Session.AppState = this;
    }
    public void Execute(string[] arguments)
    {
        Scene.DisplayText($"{GetType()}", ConsoleColor.White);
        NextState();

    }

    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? Age { get; private set; }
    public string? UserType { get; private set; }
    
    public override void NextState()
    {
        Session.AppState = new LoginState(Scene, Session);
    }


    private void PrintSigninInfo()
    {
        Scene.DisplayText($"{LastName} {FirstName}, aged {Age}, is a {UserType}",
                            ConsoleColor.DarkGreen);

    }

    private void UserDataRegistration()
    {
        /*
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

        var _tmp = Scene.GetUserInput();
        switch (_tmp)
        {
            case "1":
                UserType = "Patient";
                break;
            case "2":
                UserType = "Physicist";
                break;
            case "3":
                UserType = "Dev";
                break;
            default:
                UserType = "Default";
                break;
        }
        //PrintSigninInfo();
        Session.UserManager.CreateUser(UserType);
        //user.PersonalData = new Personal(FirstName, LastName, Age);
        */
    }
}