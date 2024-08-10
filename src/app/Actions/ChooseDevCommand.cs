using Cli.NET.Interfaces.Actions;

namespace gamedev_cli.app.Actions;

public class ChooseDevCommand : ICommand
{
    private User? _user;
    public void Execute(string[] arguments)
    {
        _user.Type = UserType.Dev;
        _user.IsLogged = true;
    }
}