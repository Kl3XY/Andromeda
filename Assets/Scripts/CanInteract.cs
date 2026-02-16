using UnityEngine;
using UnityEngine.InputSystem;
using Assets.Scripts.Interfaces;
public class CanInteract : MonoBehaviour
{
    InputAction interactButton;
    InputAction look;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactButton = InputSystem.actions.FindAction("Attack");
        look = InputSystem.actions.FindAction("Look");
    }

    // Update is called once per frame
    void Update()
    {
        Ray toMouse = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        if (Physics.Raycast(toMouse, out hit))
        {
            IInteractable obj = hit.collider.GetComponent<IInteractable>();
            if (obj != null)
            {
                InteractableUIDisplay.DisplayText = obj.Name;
                if (interactButton.WasPressedThisFrame())
                {
                    obj.CreateUI();
                }
            } else
            {
                InteractableUIDisplay.DisplayText = "";
            }
        }
    }
}
