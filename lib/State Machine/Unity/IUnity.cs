namespace gamedev.lib.State_Machine.Unity;
// brief add two concrete implementation of unity basic StateMachine
public interface IUnity
{
        public void Start();
        public void Update();
        public void TransitionToState(Enum stateKey);
}