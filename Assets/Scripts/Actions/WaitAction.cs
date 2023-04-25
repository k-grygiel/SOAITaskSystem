using AI;
using System.Collections;
using UnityEngine;

namespace Actions
{
    [CreateAssetMenu(fileName = "WaitAction", menuName = "Actions/WaitAction")]
    public class WaitAction : BaseAction
    {
        [SerializeField] private float durationInSeconds;

        public override IEnumerator Invoke(Agent agent)
        {
            yield return new WaitForSeconds(durationInSeconds);
        }
    }
}