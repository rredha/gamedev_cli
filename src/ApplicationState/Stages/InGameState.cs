namespace gamedev.ApplicationState.Stages;
public class InGameState : AppState
{
    public InGameState(AppStateContext context, AppStateMachine.AppStateEnum key) : base(context, key)
    {
    }

    public override void EnterState()
    {
       _context.Scene.DisplayText("Entering InGame State", ConsoleColor.Yellow); 
    }
    public override void UpdateState()
    {
       _context.Scene.DisplayText("Updating InGame State", ConsoleColor.Yellow); 
    }
    
    public override void ExitState()
    {
       _context.Scene.DisplayText("Exiting InGame State", ConsoleColor.Yellow); 
    }

    public override AppStateMachine.AppStateEnum GetNextState()
    {
       return AppStateMachine.AppStateEnum.InGame;
    }
}