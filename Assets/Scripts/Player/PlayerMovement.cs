
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 120.0f;

    private float playerGravity = 0f;
    private float playerDownwardsVelocity = 0f;
    private InputAction movementInput;
    private Rigidbody rb;
    private CharacterController characterController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        var move = movementInput.ReadValue<Vector2>();
        var rotate = (Quaternion.Euler(0f, 0f, 45f) * move);

        if (characterController.isGrounded)
        {
            playerGravity = 0.0f;
            playerDownwardsVelocity = 0.0f;
        } else
        {
            playerGravity += 0.3f * Time.fixedDeltaTime;
        }
        playerDownwardsVelocity += playerGravity;
        characterController.Move(new Vector3(rotate.x, -playerDownwardsVelocity, rotate.y) * speed * Time.fixedDeltaTime);
    }

}
