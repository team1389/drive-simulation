using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RobotMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10;
    public float rotateSpeed = 100;
    private Quaternion deltaRotation;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.TransformDirection(new Vector3(0, 0, Input.GetAxis("LeftJoystickY")* Time.deltaTime) * speed));
        if(Input.GetAxis("LeftJoystickY") < 0) {
            deltaRotation = Quaternion.Euler(0, -Input.GetAxis("RightJoystickX") * rotateSpeed * Time.deltaTime, 0);
        } else {
            deltaRotation = Quaternion.Euler(0, Input.GetAxis("RightJoystickX") * rotateSpeed * Time.deltaTime, 0);
        }
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
