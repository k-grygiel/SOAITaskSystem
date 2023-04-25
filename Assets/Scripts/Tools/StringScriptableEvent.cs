using System.Collections.Generic;
using UnityEngine;

namespace Tools
{
    [CreateAssetMenu(fileName = "StringScriptableEvent", menuName = "Other/StringScriptableEvent")]
    public class StringScriptableEvent : ScriptableObject
    {
        private List<IStringEventListener> listeners = new();

#if UNITY_EDITOR
        public IReadOnlyList<IStringEventListener> Listeners => listeners.AsReadOnly();
#endif
        public void RegisterListener(IStringEventListener listener)
        {
            if (listeners.Contains(listener))
                return;

            listeners.Add(listener);
        }

        public void UnregisterListener(IStringEventListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise(string value)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(value);
            }
        }
    }

    public interface IStringEventListener
    {
        public void OnEventRaised(string value);
    }
}