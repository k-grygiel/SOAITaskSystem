using UnityEngine;

namespace Tools
{
    [CreateAssetMenu(fileName = "PositionScriptableObject", menuName = "Other/PositionScriptableObject")]
    public class PositionScriptableObject : ScriptableObject
    {
        public Vector3 Position { get; private set; }

        public void SetValue(Vector3 position) => Position = position;
    }
}