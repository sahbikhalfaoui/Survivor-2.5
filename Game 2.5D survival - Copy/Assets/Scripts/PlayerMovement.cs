using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  private CharacterController characterController;
    public float speed = 5f; // Speed of the player movement
    public float jumpForce = 4f; // Force applied when jumping
    private Rigidbody rb;
    private bool isGrounded;
    

    void Start()
    {
    
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if player is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
      
        Vector3 moveDirection = new Vector3(0f, 0f, horizontalInput) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + transform.TransformDirection(moveDirection));

        // Jump
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}