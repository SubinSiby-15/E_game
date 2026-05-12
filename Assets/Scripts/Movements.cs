using UnityEngine;

public class Movements : MonoBehaviour
{
  
    public float speed = 5f;
    public float jumpForce = 7f;

    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator anim;
    public ParticleSystem dustEffect;


    private float moveInput;
    private bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            dustEffect.Play();

        }

        // Flip sprite
        if (moveInput > 0)
            sr.flipX = false;
        else if (moveInput < 0)
            sr.flipX = true;

        //Animation

            bool isRunning = moveInput != 0;
        Debug.Log("Running : " + isRunning);
            anim.SetBool("IsRunning", isRunning);
       bool IsJumping = Input.GetButtonDown("Jump") && isGrounded;
        anim.SetBool("IsGround", IsJumping);
    }

    public void MOveleft()
    {
        transform.Translate(Vector2.left* speed * Time.deltaTime);
    }
    public void MOveRight()
    {
        transform.Translate(Vector2.right* speed * Time.deltaTime);
    }





    // Ground detection using collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

