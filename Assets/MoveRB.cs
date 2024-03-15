using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    public Rigidbody rb; // Reference to the Rigidbody component

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the object
    }

    void FixedUpdate()
    {
        // Input for movement
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D keys or left/right arrow keys
        float moveVertical = Input.GetAxis("Vertical"); // W/S keys or up/down arrow keys

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply movement to the Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}
