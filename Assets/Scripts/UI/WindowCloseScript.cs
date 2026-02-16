using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class WindowCloseScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject topBarPrefab;

    InputAction mouseInteract;

    bool isHovered = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;
    }

    void Start()
    {
        mouseInteract = InputSystem.actions.FindAction("Attack");
    }

    void Update()
    {
        if (mouseInteract.IsPressed() && isHovered)
        {
            Destroy(topBarPrefab);
        }
    }
}
