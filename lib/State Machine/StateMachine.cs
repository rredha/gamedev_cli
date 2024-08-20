namespace gamedev.lib.State_Machine
{
    public abstract class StateMachine<TEnumState> where TEnumState : Enum
    {
        protected Dictionary<TEnumState, State<TEnumState>> States = new Dictionary<TEnumState, State<TEnumState>>();
        protected State<TEnumState> CurrentState;

        protected bool IsTransitionState = false;
        public void Start()
        {
            CurrentState.EnterState();
        }
        public void Update()
        {
            TEnumState nextStateKey = CurrentState.GetNextState();
            
            if (!IsTransitionState && nextStateKey.Equals(CurrentState.StateKey))
            {
                CurrentState.UpdateState();
            } else if (!IsTransitionState)
            {
                TransitionToState(nextStateKey);
            }

        }

        public void TransitionToState(TEnumState stateKey)
        {
            IsTransitionState = true;
            CurrentState.ExitState();
            CurrentState = States[stateKey];
            CurrentState.EnterState();
            IsTransitionState = false;
        }
    }
}
