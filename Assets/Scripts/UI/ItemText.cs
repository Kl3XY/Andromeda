using Assets.Scripts.Interfaces;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemText : MonoBehaviour
{
    public IItem Item {
        get
        {
            return item;
        }
        set
        {
            item = value;
            GetComponent<TextMeshProUGUI>().text = item.Name;
        }
    }

    private IItem item;

    TextMeshProUGUI textMesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
