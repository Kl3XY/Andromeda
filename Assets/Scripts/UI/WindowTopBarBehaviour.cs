using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class WindowTopBarBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject topBarPrefab;

    InputAction mouseInteract;
    InputAction deltaMouse;

    Vector2 lastMousePosition;

    bool isHovered = false;
    bool hasBeenClicked = false;

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
        deltaMouse = InputSystem.actions.FindAction("Look");
        lastMousePosition = Mouse.current.position.ReadValue();
    }

    void Update()
    {
        if (mouseInteract.IsPressed() && isHovered)
        {
            var diff = Mouse.current.position.ReadValue() - lastMousePosition;
            Debug.Log(diff);
            var newPos = new Vector3(diff.x, diff.y);
            topBarPrefab.transform.position = topBarPrefab.transform.position + newPos;
        }
        lastMousePosition = Mouse.current.position.ReadValue();
    }
}
