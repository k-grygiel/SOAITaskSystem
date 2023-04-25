using AI.StateMachine;
using Needs;
using Tools;
using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    public class Agent : MonoBehaviour
    {
        public Need CurrentNeed { get; private set; }
        public NavMeshAgent NavMeshAgent { get; private set; }
        public Vector3 ExitPosition { get; private set; }

        [field: SerializeField] public AgentSoundManager SoundManager { get; private set; }
        [Header("Events")]
        [SerializeField] private VoidScriptableEvent unitSpawnedEvent;
        [SerializeField] private VoidScriptableEvent unitDespawnedEvent;
        [SerializeField] private StringScriptableEvent unitStartedNewAction;

        #region States
        private BaseState _currentState;
        public WalkingToNeedState WalkingToNeedState { get; private set; }
        public WalkingToExitState WalkingToExitState { get; private set; }
        public FulfillingNeedState FulfillingNeedState { get; private set; }
        #endregion

        private void Awake()
        {
            unitSpawnedEvent.Raise();
            NavMeshAgent = GetComponent<NavMeshAgent>();
            WalkingToNeedState = new(this);
            WalkingToExitState = new(this);
            FulfillingNeedState = new(this);
        }

        public void Init(Need need, Vector3 exitPosition)
        {
            CurrentNeed = need;
            ExitPosition = exitPosition;
            _currentState = WalkingToNeedState;
            _currentState.Enter();
        }

        public void EnterState(BaseState state)
        {
            if (_currentState == state || state == null)
                return;

            _currentState = state;
            _currentState.Enter();
        }

        private void Update()
        {
            _currentState.Update();
        }

        internal void OnNewActionStarted(string actionName)
        {
            unitStartedNewAction.Raise(actionName);
        }

        internal void Destroy()
        {
            unitDespawnedEvent.Raise();
            Destroy(gameObject);
        }
    }
}