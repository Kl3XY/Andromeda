using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractableUIDisplay : MonoBehaviour
{
    [SerializeField] GameObject Text;
    TextMeshProUGUI text;
    public static string DisplayText = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = Text.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = DisplayText;
        Text.transform.position = Mouse.current.position.ReadValue();
    }
}
