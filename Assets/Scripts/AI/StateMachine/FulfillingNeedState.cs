namespace AI.StateMachine
{
    public class FulfillingNeedState : BaseState
    {
        public FulfillingNeedState(Agent agent) : base(agent)
        {
        }

        public override void Enter()
        {
            _agent.StartCoroutine(_agent.CurrentNeed.Fulfill(_agent,
                onNewActionStarted: (actionName) =>
                {
                    _agent.OnNewActionStarted(actionName);
                },
                onNeedFinished: () =>
                {
                    _agent.EnterState(_agent.WalkingToExitState);
                }));
        }

        public override void Update()
        {
        }
    }
}