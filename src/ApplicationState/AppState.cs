using StateMachine;
namespace gamedev.ApplicationState;

public abstract class AppState : State<AppStateMachine.AppStateEnum>
{
    protected AppStateContext _context;
    protected AppState(AppStateContext context, AppStateMachine.AppStateEnum key) : base(key)
    {
        _context = context;
    }
}