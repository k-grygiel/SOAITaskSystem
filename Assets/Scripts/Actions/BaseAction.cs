using AI;
using System.Collections;
using UnityEngine;

namespace Actions
{
    public abstract class BaseAction : ScriptableObject
    {
        [field: SerializeField] public string Name { get; protected set; }

        public abstract IEnumerator Invoke(Agent agent);
    }
}