using gamedev.lib.Cli.NET.Cli.NET.Cli.NET.Interfaces;
using gamedev.Users.Lib;

namespace gamedev.Actions;

public class ChoosePhysicianCommand : ICommand
{
    private User? _user;
    public void Execute(string[] arguments)
    {
        _user.Type = UserType.Physician;
        _user.IsLogged = true;

        SessionManager.Create();
    }
}