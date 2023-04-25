namespace AI.StateMachine
{
    public class WalkingToNeedState : BaseState
    {
        public WalkingToNeedState(Agent agent) : base(agent)
        {
        }

        public override void Enter()
        {
            _agent.NavMeshAgent.destination = _agent.CurrentNeed.Position.Position;
        }

        public override void Update()
        {
            if(HasReachedGoal())
            {
                _agent.EnterState(_agent.FulfillingNeedState);
            }
        }

        private bool HasReachedGoal()
        {
            return _agent.NavMeshAgent.remainingDistance <= _agent.NavMeshAgent.stoppingDistance;
        }
    }
}