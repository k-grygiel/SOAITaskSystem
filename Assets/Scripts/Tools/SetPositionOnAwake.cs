using UnityEngine;

namespace Tools
{
    public class SetPositionOnAwake : MonoBehaviour
    {
        [SerializeField] private PositionScriptableObject positionScriptableObject;

        private void Awake()
        {
            positionScriptableObject.SetValue(transform.position);
        }
    }
}