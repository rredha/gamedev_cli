namespace Utils;

public abstract class State
{
    public StateMachine? StateMachine { get;  }
    public abstract void Start();
}