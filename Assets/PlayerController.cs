using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;            // Constant forward speed
    public float jumpForce = 10f;           // Jump force
    public Transform groundCheckPoint;      // A point to check if the player is grounded
    public float checkRadius = 0.2f;        // Radius of the overlap circle for ground detection
    public LayerMask groundLayer;           // Layer of the ground objects

    private Rigidbody2D rb;                 // Reference to the Rigidbody2D component
    private bool isGrounded;                // Is the player on the ground?

    public AudioClip jump;
    public AudioClip backgroundMusic;

    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   // Get the Rigidbody2D component attached to the player
        sfxPlayer = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Constant forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        // Jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        anim.SetBool("IsOnGround", isGrounded);
    }

    private void Jump()
    {
        sfxPlayer.PlayOneShot(jump);
        // Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a circle to visualize the ground check point in the editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
}
