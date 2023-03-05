using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioRun : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private Animator anim;
    private bool isGrounded;

    private Vector2 touchStart;
    private bool isTouching;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the player is on the ground
        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, 0.1f, groundLayer);

        // Move the player horizontally
        float moveInput = 0f;
        if (isTouching)
        {
            float touchX = Input.GetTouch(0).position.x;
            float screenWidth = Screen.width;
            if (touchX < screenWidth / 2f)
            {
                moveInput = -1f;
            }
            else if (touchX > screenWidth / 2f)
            {
                moveInput = 1f;
            }
        }
        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y, 0f);

        // Flip the player's sprite depending on the direction they're moving
        if (moveInput > 0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (moveInput < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        // Make the player jump
        if (isTouching && Input.GetTouch(0).phase == TouchPhase.Began && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0f);
        }

        // Update the animator parameters
        anim.SetFloat("Speed", Mathf.Abs(moveInput));
        anim.SetBool("IsGrounded", isGrounded);
    }

    void FixedUpdate()
    {
        // Stop the player's horizontal movement if they're not touching the screen
        if (!isTouching)
        {
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);
        }
    }

    public void OnTouchStart()
    {
        touchStart = Input.GetTouch(0).position;
        isTouching = true;
    }

    public void OnTouchEnd()
    {
        isTouching = false;
    }
}
