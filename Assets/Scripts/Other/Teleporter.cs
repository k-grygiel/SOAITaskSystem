using UnityEngine;
using UnityEngine.AI;

public class Teleporter : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (!other.TryGetComponent(out NavMeshAgent agent))
            return;

        if (agent.isOnOffMeshLink)
            agent.CompleteOffMeshLink();
    }
}
