   using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float speedH = 2.0f;
    private float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        yaw += Input.GetAxis("Mouse X") * speedH * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * speedV * Time.deltaTime;

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f); 
    }
}
