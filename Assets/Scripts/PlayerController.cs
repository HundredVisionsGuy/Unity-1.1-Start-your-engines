using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehicle left and right
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Turn vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
