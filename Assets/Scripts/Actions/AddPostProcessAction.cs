using AI;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Actions
{
    [CreateAssetMenu(fileName = "AddPostProcessAction", menuName = "Actions/AddPostProcessAction")]
    public class AddPostProcessAction : BaseAction
    {
        [SerializeField] private VolumeProfile globalPostProcessing;
        [SerializeField] private bool activate;

        public override IEnumerator Invoke(Agent agent)
        {
            if (globalPostProcessing.TryGet(out LiftGammaGain liftGammaGain))
                liftGammaGain.active = activate;

            yield return null;
        }
    }
}