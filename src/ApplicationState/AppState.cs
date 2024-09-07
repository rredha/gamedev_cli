using gamedev.lib.State_Machine;

namespace gamedev.ApplicationState;

public delegate void StateChangedEventHandler();
public abstract class AppState : State<AppStateMachine.AppStateEnum>
{
    protected AppStateContext _context;
    protected AppState(AppStateContext context, AppStateMachine.AppStateEnum key) : base(key)
    {
        _context = context;
    }
    public event StateChangedEventHandler StateChanged;  
    protected void OnStateChanged()
    {
        StateChanged?.Invoke();
    }
}