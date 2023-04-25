using AI;
using System.Collections;
using UnityEngine;

namespace Actions
{
    [CreateAssetMenu(fileName = "ParticlesAction", menuName = "Actions/ParticlesAction")]
    public class ParticlesAction : BaseAction
    {
        [SerializeField] private ParticleSystem particlePrefab;
        [SerializeField] private float lifetime;

        public override IEnumerator Invoke(Agent agent)
        {
            var particles = Instantiate(particlePrefab, agent.transform.position, Quaternion.identity);
            particles.Play();
            Destroy(particles.gameObject, lifetime);
            yield return null;
        }
    }
}