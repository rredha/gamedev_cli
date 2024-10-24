using Cli.NET.Interfaces.Actions;
using Cli.NET.Models;
using gamedev.ApplicationState.Stages.UserRegistration;
using gamedev.lib.Mock;
using gamedev.User;

namespace gamedev.ApplicationState.Stages;

public class UserRegistrationState : AppState
{
    public Scene Scene { get; set; }
    public Session Session { get; set; }
    private CommandList userRegistrationCommands;


    public UserRegistrationState(Scene scene, Session session)
    {
        Scene = scene;
        Session = session;
        userRegistrationCommands = new CommandList
        {
            { "Signin", new SigninState(Scene, Session) },
            { "Login", new LoginState(Scene, Session) }
        };
        
        Scene.Options(userRegistrationCommands);
        Scene.Container.Register(userRegistrationCommands);
        Scene.DisplayText($"In {GetType()}", ConsoleColor.White);
        Scene.WaitForUserCommand();
    }

    public override void NextState()
    {
    }
}