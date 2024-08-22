namespace gamedev.lib.State_Machine
{
    public abstract class State<TEnumState> where TEnumState : Enum
    {
        public State(TEnumState key)
        {
            StateKey = key;
        }

        public TEnumState StateKey { get; private set; }

        public abstract void EnterState();
        public abstract void ExitState();
        public abstract void UpdateState();
        public abstract TEnumState GetNextState();
        public delegate void AppStateChangedEventHandler(object source, EventArgs args);

        public event AppStateChangedEventHandler AppStateChanged;

        protected virtual void OnAppStateChanged()
        {
            if (AppStateChanged != null)
                AppStateChanged(this, EventArgs.Empty);
        }
        }
}