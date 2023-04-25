using UnityEngine;
using UnityEngine.Events;

namespace Tools
{
    public class VoidEventListener : MonoBehaviour, IVoidEventListener
    {
        [SerializeField] private VoidScriptableEvent gameEvent;
        [SerializeField] private UnityEvent response;

        private void OnEnable() => gameEvent.RegisterListener(this);

        private void OnDisable() => gameEvent.UnregisterListener(this);

        public void OnEventRaised()
        {
            response?.Invoke();
        }
    }
}