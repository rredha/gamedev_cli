using gamedev.ApplicationState;
namespace gamedev;
public class LoginState : AppState
{
    public LoginState(AppStateContext context, AppStateMachine.AppStateEnum key) : base(context ,key)
    {
        AppStateContext Context = context;
    }
    public override void EnterState()
    {
        throw new NotImplementedException();
    }

    public override void ExitState()
    {
        throw new NotImplementedException();
    }

    public override void UpdateState()
    {
        throw new NotImplementedException();
    }

    public override AppStateMachine.AppStateEnum GetNextState()
    {
        throw new NotImplementedException();
    }

}