using UnityEngine;

public class PlayerCamController : MonoBehaviour
{
    //Movement
    //ObjectRefs
    public Transform PlayerCamera;
    public Transform Orientation;
    public Transform Head;

    //Vars
    public float mouseSensitivity;
    public float accelSpeed;
    public float maxSpeed;
    float xRotation;

    public float counterMovement;
    public float counterMovementThreshold;

    //Input
    float xInput, zInput, mouseX, mouseY;
    bool jumpInput;
    bool crouchInput;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Update()
    {
        FetchInputs();
        CameraControl();

        //basic movement
        transform.Translate(new Vector3(xInput * maxSpeed * Time.deltaTime, ((jumpInput ? 1 : 0) + (crouchInput ? -1 : 0)) * maxSpeed * Time.deltaTime, zInput * maxSpeed * Time.deltaTime));
    }

    void FetchInputs()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xInput = (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0);
        zInput = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);

        jumpInput = Input.GetKey(KeyCode.Space);
        crouchInput = Input.GetKey(KeyCode.LeftShift);
    }

    void CameraControl()
    {
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        PlayerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Orientation.Rotate(Vector3.up * mouseX);

    }
}
