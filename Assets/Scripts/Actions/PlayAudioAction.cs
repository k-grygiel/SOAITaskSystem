using AI;
using System.Collections;
using UnityEngine;

namespace Actions
{
    [CreateAssetMenu(fileName = "PlayAudioAction", menuName = "Actions/PlayAudioAction")]
    public class PlayAudioAction : BaseAction
    {
        [SerializeField] private AudioClip audioClip;

        public override IEnumerator Invoke(Agent agent)
        {
            agent.SoundManager.PlayOneShot(audioClip);
            yield return null;
        }
    }
}