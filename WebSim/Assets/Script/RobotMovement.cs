using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RobotMovement : MonoBehaviour
{
    public Rigidbody rb;
    public static float speed;
    public static float rotateSpeed;
    private Quaternion deltaRotation;

    private void Start()
    {
        speed = UIManager.speedChange;
        rotateSpeed = UIManager.rotateChange;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.TransformDirection(new Vector3(0, 0, Input.GetAxis("LeftJoystickY") * Time.deltaTime) * speed));
        if(Input.GetAxis("LeftJoystickY") < 0) {
            deltaRotation = Quaternion.Euler(0, -Input.GetAxis("RightJoystickX") * rotateSpeed * Time.deltaTime, 0);
        } else {
            deltaRotation = Quaternion.Euler(0, Input.GetAxis("RightJoystickX") * rotateSpeed * Time.deltaTime, 0);
        }
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
