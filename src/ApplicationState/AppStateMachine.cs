using gamedev.ApplicationState.Stages;
//using gamedev.Events;
using gamedev.lib.State_Machine;
//using gamedev.lib.State_Machine.Cli;

namespace gamedev.ApplicationState;
public class AppStateMachine : StateMachine<AppStateMachine.AppStateEnum>
{
    private AppStateContext _context; 
    public AppStateMachine(AppStateContext context)
    {
        _context = context;
        InitialiseState();
        SetInitialState();
    }

    public void CurrentStateChange()
    {
        Start();
        Update();
    }
    public enum AppStateEnum
    {
        Login,
        Main,
        InGame,
    }


    // Made it public to access it in this instance,
    // since there is no event system like the Unity Monobehaviour
    // loop cycle.
    // Could also mock it, I'll see that later.
    public void InitialiseState()
    {
        States.Add(AppStateEnum.Login, new LoginState(_context, AppStateEnum.Login));
        States.Add(AppStateEnum.Main, new MainState(_context, AppStateEnum.Main));
        States.Add(AppStateEnum.InGame, new InGameState(_context, AppStateEnum.InGame));
    }

    public void SetInitialState()
    {
        CurrentState = States[AppStateEnum.Login];
    }

    // AppStateMachine is the Subscriber
}
