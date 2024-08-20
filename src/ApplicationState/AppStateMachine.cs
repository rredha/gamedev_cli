using gamedev.lib.State_Machine;

namespace gamedev.ApplicationState;
public class AppStateMachine : StateMachine<AppStateMachine.AppStateEnum>
{
    private AppStateContext _context;
    public enum AppStateEnum
    {
        Login,
        Main,
        InGame,
    }

    private void InitialiseState()
    {
        States.Add(AppStateEnum.Login, new LoginState(_context, AppStateEnum.Login));
        States.Add(AppStateEnum.Main, new MainState(_context, AppStateEnum.Main));
        States.Add(AppStateEnum.InGame, new InGameState(_context, AppStateEnum.InGame));
    }
}
