using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Interfaces;
using gamedev.Users.Lib;

namespace gamedev.Actions;

public class ChoosePatientCommand : ICommand
{
    private User? _user;
    public void Execute(string[] arguments)
    {
        _user.Type = UserType.Patient;
        _user.IsLogged = true;
    }
}