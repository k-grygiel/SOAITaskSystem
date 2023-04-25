using AI;
using Needs;
using Tools;
using UnityEngine;

namespace Spawner
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField] private Agent agentPrefab;
        [SerializeField] private NeedsManager needsManager;
        [SerializeField] private PositionScriptableObject spawnPoint;
        [SerializeField] private PositionScriptableObject exitPosition;

        private Agent _currentAgent;

        private void Start()
        {
            SpawnUnit();
        }

        public void SpawnUnit()
        {
            _currentAgent = Instantiate(agentPrefab, spawnPoint.Position, Quaternion.identity);
            _currentAgent.Init(needsManager.GetRandomNeed(), exitPosition.Position);
        }
    }
}