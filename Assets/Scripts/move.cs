using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float jumpForce = 5f;

    public bool isGrounded;

    public SpriteRenderer sr;
    public Animator anim;

    float moveInput;
    public float uiMoveInput = 0f; // Input from UI buttons

    void Update()
    {
        // Combine keyboard + UI input (optional, remove keyboard if not needed)
        moveInput = Input.GetAxis("Horizontal") + uiMoveInput;
        moveInput = Mathf.Clamp(moveInput, -1f, 1f);

        // Movement
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        // Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // Flip sprite
        if (moveInput > 0)
            sr.flipX = false;
        else if (moveInput < 0)
            sr.flipX = true;

        // Animation
        bool isRunning = moveInput != 0;
        anim.SetBool("IsRunning", isRunning);

        anim.SetBool("IsGround", isGrounded);
    }

    // ---------- UI BUTTON FUNCTIONS ----------

    public void MoveLeftDown()
    {
        uiMoveInput = -1f;
    }

    public void MoveRightDown()
    {
        uiMoveInput = 1f;
    }

    public void StopMove()
    {
        uiMoveInput = 0f;
    }
}