using System.Net.WebSockets;
using TMPro;
using UnityEngine;

public class WindowInformation : MonoBehaviour
{
    [SerializeField] GameObject windowTitleObject;
    [SerializeField] GameObject interactionDescriptionObject;
    public GameObject ReferenceObject;
    public string WindowTitle {
        get 
        {  
            return windowTitleObject.GetComponent<TextMeshProUGUI>().text; 
        }
        set
        {
            windowTitleObject.GetComponent<TextMeshProUGUI>().text = value;
        }
    }

    public string InteractionDescription
    {
        get
        {
            return interactionDescriptionObject.GetComponent<TextMeshProUGUI>().text;
        }
        set
        {
            interactionDescriptionObject.GetComponent<TextMeshProUGUI>().text = value;
        }
    }

}
