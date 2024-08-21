namespace gamedev.ApplicationState.Stages;
public class LoginState : AppState
{
    public LoginState(AppStateContext context, AppStateMachine.AppStateEnum key) : base(context ,key)
    {
    }


    public override void EnterState()
    {
       _context.Scene.DisplayText("Entering Login State", ConsoleColor.Red); 
    }
    public override void UpdateState()
    {
       _context.Scene.DisplayText("Updating Login State", ConsoleColor.Red); 
    }
    
    public override void ExitState()
    {
       _context.Scene.DisplayText("Exiting Login State", ConsoleColor.Red); 
    }

    public override AppStateMachine.AppStateEnum GetNextState()
    {
       return AppStateMachine.AppStateEnum.Main;
    }

}