using AI;
using System.Collections;
using UnityEngine;

namespace Actions
{
    [CreateAssetMenu(fileName = "TextBubbleAction", menuName = "Actions/TextBubbleAction")]
    public class TextBubbleAction : BaseAction
    {
        [SerializeField] private TextBubble textBubblePrefab;
        [SerializeField] private string text;
        [SerializeField] private float lifetime;

        public override IEnumerator Invoke(Agent agent)
        {
            var bubble = Instantiate(textBubblePrefab, agent.transform.position + Vector3.up, Quaternion.identity);
            bubble.SetText(text);
            Destroy(bubble.gameObject, lifetime);
            yield return null;
        }
    }
}