using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class WindowInteractButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject RootPrefab;

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
        if (mouseInteract.WasPressedThisFrame() && isHovered)
        {
            var script = RootPrefab.GetComponent<WindowInformation>();
            var obj = script.ReferenceObject.GetComponent<IInteractable>();
            obj.Interact();
        }
    }
}
