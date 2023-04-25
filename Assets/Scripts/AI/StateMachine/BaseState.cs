namespace AI.StateMachine
{
    public abstract class BaseState
    {
        protected Agent _agent;

        public BaseState(Agent agent)
        {
            _agent = agent;
        }

        public abstract void Enter();
        public abstract void Update();
    }
}