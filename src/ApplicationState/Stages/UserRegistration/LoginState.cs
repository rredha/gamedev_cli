using Cli.NET.Interfaces.Actions;
using CsvHelper.Configuration.Attributes;
using gamedev.ApplicationState.Stages.GameLibrary;
using gamedev.lib.Mock;

namespace gamedev.ApplicationState.Stages.UserRegistration;

public class LoginState : AppState, ICommand
{
    public Scene Scene { get; set; }
    public Session Session { get; set; }
    public string? LastName { get; set; }
    private bool _isLogged = false;
    public LoginState(Scene scene, Session session)
    {
        Scene = scene;
        Session = session;
    }
    public void Execute(string[] arguments)
    {
        Scene.DisplayText($"{GetType()}", ConsoleColor.White);
        NextState();
    }
    public override void NextState()
    {
        Session.AppState = new MainState(Scene, Session);
    }

    private void UserDataValidation()
    {
        /*
       Console.Clear();
       Scene.DisplayText("Enter Your Last Name", ConsoleColor.Yellow);
       LastName = Scene.GetUserInput();
       Scene.DisplayText("Verification....", ConsoleColor.Yellow);
       _isLogged = true;
       Scene.DisplayText("Logged in Successfully", ConsoleColor.Yellow);
       */
    }

}