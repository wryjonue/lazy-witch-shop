using UnityEngine;
using UnityEngine.InputSystem; // Must have this

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator anim;
    private SpriteRenderer spriteRenderer;
    void Start() {
        Debug.Log("starting script");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // When Behavior is 'Send Messages', Unity looks for this EXACT name
    // It must take 'InputValue' as a parameter
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log("Movement Vector: " + moveInput);
        bool walking = moveInput.magnitude > 0;
        anim.SetBool("isWalking", walking);// This is your console.log
        if (moveInput.x < 0) {
            // If moving left, flip the sprite
            spriteRenderer.flipX = true;
        } else if (moveInput.x > 0) {
            // If moving right, don't flip
            spriteRenderer.flipX = false;
        }
    }

    void FixedUpdate()
    {
        // Check if the player is actually receiving input
        rb.linearVelocity = moveInput * moveSpeed;
    }
}