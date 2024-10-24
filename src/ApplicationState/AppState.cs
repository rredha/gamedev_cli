using Cli.NET.Interfaces.Actions;

namespace gamedev.ApplicationState;

public abstract class AppState
{
    public ICommand Command { get; protected set; }

    public abstract void NextState();
}