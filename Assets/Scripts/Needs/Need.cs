using Actions;
using AI;
using System;
using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;

namespace Needs
{
    [CreateAssetMenu(fileName = "Need")]
    public class Need : ScriptableObject
    {
        [field: SerializeField] public PositionScriptableObject Position { get; private set; }
        [field: SerializeField] public List<BaseAction> Actions { get; private set; }

        public IEnumerator Fulfill(Agent agent, Action<string> onNewActionStarted = null, Action onNeedFinished = null)
        {
            for (int i = 0; i < Actions.Count; i++)
            {
                onNewActionStarted.Invoke(Actions[i].Name);
                yield return agent.StartCoroutine(Actions[i].Invoke(agent));
            }

            onNeedFinished?.Invoke();
        }
    }
}