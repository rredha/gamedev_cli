namespace gamedev.lib.State_Machine
{
    public delegate void EventHandler();
    public abstract class State<TEnumState> where TEnumState : Enum
    {
        public State(TEnumState key)
        {
            StateKey = key;
        }

        public event EventHandler StateChanged;

        protected virtual void OnStateChanged()
        {
            StateChanged?.Invoke();
        }

        public TEnumState StateKey { get; private set; }

        public abstract void EnterState();
        public abstract void ExitState();
        public abstract void UpdateState();
        public abstract TEnumState GetNextState();

    }
}