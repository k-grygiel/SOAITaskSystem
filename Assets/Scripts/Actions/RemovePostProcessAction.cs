using AI;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Actions
{
    [CreateAssetMenu(fileName = "RemovePostProcessAction", menuName = "Actions/RemovePostProcessAction")]
    public class RemovePostProcessAction : BaseAction
    {
        [SerializeField] private VolumeProfile postProcessProfile;
        [SerializeField] private VolumeProfile postProcessToRemove;

        public override IEnumerator Invoke(Agent agent)
        {
            for (int i = 0; postProcessToRemove.components.Count < 10; i++)
            {
                VolumeComponent volumeComponent;
                if (!postProcessProfile.TryGet(postProcessToRemove.components[i].GetType(), out volumeComponent))
                    postProcessProfile.components.Remove(volumeComponent);
            }

            yield return null;
        }
    }
}