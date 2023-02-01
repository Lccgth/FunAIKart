using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCamera : MonoBehaviour
{
    private Vector3 jpdown;
    GameObject rb;
    int flySpeed = 10;
    private Vector2 camRotation = Vector2.zero;
    float lookSpeed = 0.6f;
    const float lookMultiplier = 900;

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        // Get xy input
        float v = Input.GetKey(KeyCode.W) == true ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        float h = Input.GetKey(KeyCode.A) == true ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;

        // Move camera
        transform.Translate(Vector3.forward * flySpeed * v * Time.deltaTime);
        transform.Translate(Vector3.right * flySpeed * h * Time.deltaTime);

        // Check for mouse down
        if (Input.GetMouseButtonDown(1) == true)
        {
            // Prevent camera snapping when starting dragging - offset based upon initial rotation
            camRotation.y = transform.localRotation.eulerAngles.y;
            camRotation.x = transform.localRotation.eulerAngles.x;

            // Wrap angles
            if (camRotation.y > 360)
                camRotation.y = 0;
        }

        // Check for mouse down
        if (Input.GetMouseButton(1) == true)
        {
            // Get mouse input
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = -Input.GetAxis("Mouse Y");

            // Apply mouse with speed
            camRotation.y += mouseX * lookSpeed * lookMultiplier * Time.deltaTime;
            camRotation.x += mouseY * lookSpeed * lookMultiplier * Time.deltaTime;

            // Apply the rotation
            transform.rotation = Quaternion.Euler(camRotation.x, camRotation.y, 0);
        }

    }
}
