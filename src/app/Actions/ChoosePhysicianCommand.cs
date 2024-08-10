using Cli.NET.Interfaces.Actions;

namespace gamedev_cli.app.Actions;

public class ChoosePhysicianCommand : ICommand
{
    private User? _user;
    public void Execute(string[] arguments)
    {
        _user.Type = UserType.Physician;
        _user.IsLogged = true;

        SessionManager.Create(new Session());
    }
}