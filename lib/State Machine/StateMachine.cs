namespace gamedev.lib.State_Machine
{
    public abstract class StateMachine<TEnumState> where TEnumState : Enum
    {
        protected Dictionary<TEnumState, State<TEnumState>> States =
            new Dictionary<TEnumState, State<TEnumState>>();
        // changed to check if it will work with Events
        // protected State<TEnumState> CurrentState;
        public State<TEnumState> CurrentState { get; set; }
        
        /*
         * Subscriber is the StateMachine
         * Do i need to have a constructor ????
         */

        /*
        public StateMachine(State<TEnumState> currentState)
        {
            CurrentState = currentState;
            CurrentState.StateChanged += Start;
            CurrentState.StateChanged += Update;
        }
        */
        public void Start()
        {
            CurrentState.EnterState();
        }
        public void Update()
        {
            TEnumState nextStateKey = CurrentState.GetNextState();
            
            if (nextStateKey.Equals(CurrentState.StateKey)) 
            {
                CurrentState.UpdateState();
            } 
            TransitionToState(nextStateKey);
        }

        private void TransitionToState(TEnumState stateKey)
        {
            CurrentState.ExitState();
            CurrentState = States[stateKey];
            CurrentState.EnterState();
        }
        
    }
}
