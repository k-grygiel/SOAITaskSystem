using UnityEngine;

namespace AI
{
    public class AgentSoundManager : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        public void PlayOneShot(AudioClip clip)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}