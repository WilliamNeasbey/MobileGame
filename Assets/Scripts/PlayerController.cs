using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    private float moveX;

    // For mobile controls
    public Joystick joystick;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from virtual joystick
       moveX = joystick.Horizontal * moveSpeed;

        // Get input from keyboard or D-pad (only if virtual joystick isn't being used)
        if (Mathf.Approximately(moveX, 0f))
        {
            moveX = Input.GetAxis("Horizontal") * moveSpeed;
            
        }
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }
}
