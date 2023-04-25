using UnityEngine;
using UnityEngine.Events;

namespace Tools
{
    public class StringEventListener : MonoBehaviour, IStringEventListener
    {
        [SerializeField] private StringScriptableEvent gameEvent;
        [SerializeField] private UnityEvent<string> response;

        private void OnEnable() => gameEvent.RegisterListener(this);

        private void OnDisable() => gameEvent.UnregisterListener(this);

        public void OnEventRaised(string value)
        {
            response?.Invoke(value);
        }
    }
}