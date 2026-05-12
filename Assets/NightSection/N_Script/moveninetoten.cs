using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class moveninetoten : MonoBehaviour
{
    public float Speed = 10.0f;

    public float moveX;
    public float moveY;
    public float Jump;
    public float JumpForce = 5.5f;
    public int Health = 100;

    private bool IsGrounded;

    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator anim;


    public GameObject GameObject;


/*
    // Ground Checker Variables
    public Transform groundCheck;
    private string lastMethod = "";
    public LayerMask groundLayer;
    public float raycastDistance = 1.0f;
    public Vector2 boxSize = new Vector2(0.5f, 0.1f); // For OverlapBox
    public float checkRadius = 0.2f; // For OverlapCircle
*/

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();

    }


    private void Update()
    {






        //  IsGrounded = CheckGroundOverlapBox();

        moveX = Input.GetAxisRaw("Horizontal"); // -1 , 0 , 1  : -1 is for left , 0 is for no movement and 1 is for right
        // moveY = Input.GetAxisRaw("Vertical");  // -1 , 0 , 1

        Jump = Input.GetAxis("Jump"); // 1,0


        rb.linearVelocity = new Vector2(moveX * Speed, rb.linearVelocity.y);   // using linear velocity for horizontal movement


        if (IsGrounded && Jump > 0)
        {
            rb.linearVelocity = new Vector2(0, moveY * JumpForce); // using linear velocity for vertical movement
        }


        // Animation 
        bool isRunning = moveX != 0;  // true if the player is moving horizontally(left & right), false otherwise (idle)
        anim.SetBool("Running", isRunning);





        // Flip Using Sprite Renderer
      
        if (moveX > 0)
        {
            sr.flipX = false; // Facing right
        }
        else if (moveX < 0)
        {
            sr.flipX = true; // Facing left
        }




        /*

       rb.MovePosition(rb.position * (moveX * Speed * Time.deltaTime)); // using MovePosition for horizontal movement

        if (IsGrounded && Jump > 0)
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse); // using AddForce for jumping
        }

        transform.Translate(Vector2.right * moveX * Speed * Time.deltaTime);


        if (IsGrounded && Jump > 0)
        {
            transform.Translate(Vector2.up * Jump * JumpForce * Time.deltaTime);
        }

        */

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
            Debug.Log("Player is In ground : " + IsGrounded);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
            Debug.Log("Player is In ground : " + IsGrounded);
        }
    }
}

/*
// Ground Chceking using RayCast
private bool CheckGroundRaycast()
{
    lastMethod = "Raycast";
    RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, raycastDistance, groundLayer);
    return hit.collider != null;
}

// Ground Chceking using OverlapBox
private bool CheckGroundOverlapBox()
{
    lastMethod = "Box";
    return Physics2D.OverlapBox(groundCheck.position,boxSize, 0f, groundLayer) != null;

}

// Ground Chceking using OverlapCricled
private bool CheckGroundOverlapCircle()
{
    lastMethod = "Circle";
    return Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer) != null;
}


void OnDrawGizmosSelected()
{
    if (groundCheck == null) return;

    Gizmos.color = Color.red;


    if (lastMethod == "Raycast")
    {
        Gizmos.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * raycastDistance);
    }
    else if (lastMethod == "Box")
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(groundCheck.position, boxSize);
    }
    else if (lastMethod == "Circle")
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
    }

}

}*/

/*
 * 
        // transform.Translate(Vector2.right*Speed *Time.deltaTime );// moves right at a constant speed of 10 units per second.
        // transform.Translate(Vector2.up * moveY* Speed * Time.deltaTime);
        //  Vector2 direction = new Vector2(moveX, moveY);
        //   transform.Translate(direction * Speed * Time.deltaTime);
 * 
 * 
 * // Debug.Log(Vector2.right * Speed * Time.deltaTime);

        // transform.position=new Vector2(Speed*Time.deltaTime,0);

        //transform.position +=new Vector3(Speed*Time.deltaTime,0,0); // 
        if(name=="Square")
        {

            transform.Translate(Vector2.up * Speed * Time.deltaTime);

        } 

  if (Input.GetMouseButton(0))
        {
            Debug.Log("Left mouse button is being held down.");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Left mouse button was just pressed.");
        }
        else if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("Left mouse button was just released.");
        }


        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key is being held down.");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(" enter key was just pressed.");
        }
        else if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Debug.Log("1  key was just released.");
        }
*/

/*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Blue"))
        {
            Health++;
         
        }
        if (collision.gameObject.CompareTag("Red"))
        {
           // Debug.Log("Collided with Red! Enter"); 
            
            Health--;
        
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Red"))
        {
            //Debug.Log("Collided with Red! Exit");
       
          
        }
        if(collision.gameObject.CompareTag("Blue"))
        {
            // Debug.Log("Collided with Bllue! Exit");
        
          
        }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("blue"))
        {
            //Debug.Log("Collided with Blue! Stay");
            Health++;
        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
     
        if (collision.gameObject.CompareTag("Red"))
        {
            //Debug.Log("Collided with Red! stay");
            Health--;
        }


    }
    } */

