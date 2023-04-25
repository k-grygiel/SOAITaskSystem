using TMPro;
using UnityEngine;

public class TextBubble : MonoBehaviour
{
    [SerializeField] TextMeshPro tmpText;

    private void OnEnable()
    {
        transform.rotation = Quaternion.Euler(90, -90, 0);
    }
    public void SetText(string text) => tmpText.SetText(text);
}
