namespace gamedev.ApplicationState.Stages;
public class MainState : AppState
{
    public MainState(AppStateContext context, AppStateMachine.AppStateEnum key) : base(context, key)
    {
    }

    public override void EnterState()
    {
       _context.Scene.DisplayText("Entering Main State", ConsoleColor.Magenta); 
    }
    public override void UpdateState()
    {
       _context.Scene.DisplayText("Updating Main State", ConsoleColor.Magenta); 
    }
    
    public override void ExitState()
    {
       _context.Scene.DisplayText("Exiting Login State", ConsoleColor.Magenta); 
    }

    public override AppStateMachine.AppStateEnum GetNextState()
    {
       return AppStateMachine.AppStateEnum.InGame;
    }

}