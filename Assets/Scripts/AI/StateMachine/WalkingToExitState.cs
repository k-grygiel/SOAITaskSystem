using UnityEngine;

namespace AI.StateMachine
{
    public class WalkingToExitState : BaseState
    {
        public WalkingToExitState(Agent agent) : base(agent)
        {
        }

        public override void Enter()
        {
            _agent.NavMeshAgent.destination = _agent.ExitPosition;
        }

        public override void Update()
        {
            if (HasReachedGoal())
            {
                _agent.Destroy();
            }
        }

        private bool HasReachedGoal()
        {
            return _agent.NavMeshAgent.remainingDistance <= _agent.NavMeshAgent.stoppingDistance;
        }
    }
}