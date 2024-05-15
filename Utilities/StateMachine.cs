namespace Utilities;
/*
public abstract class StateMachine
{
   protected State State;

   public void SetState(State state)
   {
      State = state;
   }

}
*/
public class StateMachine
{
    public enum State 
    {
        LevelInit,
        Pick,
        Aim,
        Shoot,
        Won,
        Lost,
    }   
}
