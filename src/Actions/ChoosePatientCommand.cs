using Cli.NET.Interfaces.Actions;

namespace gamedev_cli.app.Actions;

public class ChoosePatientCommand : ICommand
{
    private User? _user;
    public void Execute(string[] arguments)
    {
        _user.Type = UserType.Patient;
        _user.IsLogged = true;
    }
}