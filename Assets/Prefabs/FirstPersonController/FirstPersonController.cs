using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class FirstPersonController : MonoBehaviour
{
    public float verticalCameraMultiplier = 1f;
    public float horizontalCameraMultiplier = 1f;
    public float movementSpeed = 30f;
    private float verticalCameraRotation = 0f;
    public Camera playerCamera;
    public InputMaster controls;
    private CharacterController characterController;
    Vector2 movementInput;
    Vector2 lookInput;
    Vector3 movement;
    Vector2 rotation;
    Vector3 gravityVelocity = new Vector3(0,0,0);
    public Transform groundCheck;
    public float groundCheckDistance = 1f;
    private LayerMask groundCheckMask;
    bool isGrounded;


    void Awake(){
        print("Awake test");
        controls = new InputMaster();
        characterController = GetComponent<CharacterController>();
        groundCheck = gameObject.transform.GetChild(2);

        controls.FirstPersonController.Move.performed += context => movementInput = context.ReadValue<Vector2>();
        controls.FirstPersonController.Move.canceled += context => movementInput = Vector2.zero;

        controls.FirstPersonController.Look.performed += context => lookInput = context.ReadValue<Vector2>();
        controls.FirstPersonController.Look.canceled += context => lookInput = Vector2.zero;
        if(playerCamera == null){
            print("aww, shucks, you forgot the camera :(");
        }
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
        GroundedCheck();
        Move(movementInput);
        Look(lookInput);
    }    

    void FixedUpdate(){
        //print("Update test");
        //Move(movementInput);
        //Look(lookInput);
        /*Vector2 movement = new Vector3(movementInput.x, 0, movementInput.y) * Time.deltaTime;
        transform.Translate(movement, Space.Self);

        Vector2 test2 = new Vector2(lookInput.y, lookInput.x) * 100f * Time.deltaTime;
        transform.Rotate(test2, Space.Self);
        print(movement * 100);
        print(test2);*/
    }

    void GroundedCheck(){
        isGrounded = Physics.Raycast(groundCheck.transform.position, -Vector3.up, groundCheckDistance);
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundCheckMask);
        if (isGrounded && (gravityVelocity.y < 0f)){
            gravityVelocity = new Vector3(0f, -2f, 0f);
        }
    }

    void Move(Vector2 movementInput){
        //print(movementInput);
        movement = (transform.forward * movementInput.y) + (transform.right * movementInput.x);
        //transform.Translate(new Vector3(movementInput.x, 0, movementInput.y) * Time.deltaTime * movementSpeed, Space.Self);
        characterController.Move(movement * Time.deltaTime * movementSpeed);
        gravityVelocity += Physics.gravity * Time.deltaTime;
        characterController.Move(gravityVelocity * Time.deltaTime);
    }

    void Look(Vector2 lookInput){
        //print(lookInput);
        verticalCameraRotation -= (lookInput.y * verticalCameraMultiplier) * Time.deltaTime;
        verticalCameraRotation = Mathf.Clamp(verticalCameraRotation, -90f, 90f);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalCameraRotation, 0f, 0f);
        //playerCamera.transform.Rotate(new Vector3((-lookInput.y * verticalCameraMultiplier), 0, 0) * Time.deltaTime, Space.Self);
        //playerCamera.transform.localRotation = Quaternion.Euler(new Vector3(Mathf.Clamp(playerCamera.transform.rotation.x, -90f, 90f), 0f, 0f));
        transform.Rotate(new Vector3(0, lookInput.x * horizontalCameraMultiplier, 0) * Time.deltaTime, Space.Self);
    }

    /*
        public void OnMove(InputAction.CallbackContext context)
    {
        m_Move = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        m_Look = context.ReadValue<Vector2>();
    }

    public void Update()
    {
        // Update orientation first, then move. Otherwise move orientation will lag
        // behind by one frame.
        Look(m_Look);
        Move(m_Move);
    }

    private void Move(Vector2 direction)
    {
        if (direction.sqrMagnitude < 0.01)
            return;
        var scaledMoveSpeed = moveSpeed * Time.deltaTime;
        // For simplicity's sake, we just keep movement in a single plane here. Rotate
        // direction according to world Y rotation of player.
        var move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
        transform.position += move * scaledMoveSpeed;
    }

    private void Look(Vector2 rotate)
    {
        if (rotate.sqrMagnitude < 0.01)
            return;
        var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
        m_Rotation.y += rotate.x * scaledRotateSpeed;
        m_Rotation.x = Mathf.Clamp(m_Rotation.x - rotate.y * scaledRotateSpeed, -89, 89);
        transform.localEulerAngles = m_Rotation;
    }
 */

    void OnEnable(){
        controls.FirstPersonController.Enable();
    }

    void OnDisable(){
        controls.FirstPersonController.Disable();
    }
}
