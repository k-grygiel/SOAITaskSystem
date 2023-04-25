using UnityEngine;

namespace Needs
{
    public class NeedsManager : MonoBehaviour
    {
        [SerializeField] private Need[] needs;

        private void Awake()
        {
            Random.InitState(System.DateTime.Now.Millisecond);
        }

        public Need GetRandomNeed() => needs[Random.Range(0, needs.Length)];
    }
}