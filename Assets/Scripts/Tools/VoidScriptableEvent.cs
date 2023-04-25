using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    [CreateAssetMenu(fileName = "VoidScriptableEvent", menuName = "Other/VoidScriptableEvent")]
    public class VoidScriptableEvent : ScriptableObject
    {
        private List<IVoidEventListener> listeners = new();

#if UNITY_EDITOR
        public IReadOnlyList<IVoidEventListener> Listeners => listeners.AsReadOnly();
#endif
        public void RegisterListener(IVoidEventListener listener)
        {
            if (listeners.Contains(listener))
                return;

            listeners.Add(listener);
        }

        public void UnregisterListener(IVoidEventListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }
    }

    public interface IVoidEventListener
    {
        public void OnEventRaised();
    }
}