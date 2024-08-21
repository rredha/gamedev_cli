using gamedev.ApplicationState.Stages;
using gamedev.lib.State_Machine;

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
        CurrentState = States[AppStateEnum.Login];
    }
}
