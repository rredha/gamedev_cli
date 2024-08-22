using gamedev.ApplicationState.Stages;
using gamedev.Events;
using gamedev.lib.State_Machine;
using gamedev.lib.State_Machine.Cli;

namespace gamedev.ApplicationState;
public class AppStateMachine : StateMachine<AppStateMachine.AppStateEnum>
{
    public AppStateContext Context { get; init; }

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
        States.Add(AppStateEnum.Login, new LoginState(Context, AppStateEnum.Login));
        States.Add(AppStateEnum.Main, new MainState(Context, AppStateEnum.Main));
        States.Add(AppStateEnum.InGame, new InGameState(Context, AppStateEnum.InGame));
    }

    public void SetInitialState()
    {
        CurrentState = States[AppStateEnum.Login];
    }

    public void RunAppStateMachine()
    {
        Start();
        Update();
    }

    // AppStateMachine is the Subscriber
    public void OnAppStateChanged(object source, EventArgs e)
    {
        RunAppStateMachine();
    }


}
