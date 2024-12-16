using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private float Move;
    public float speed;
    public float jump;
    public Vector2 boxSide;
    public float castDistance;
    public LayerMask groundLayer;
    
    private bool isFacingRight;
    private float horizontal;
    public BookManager BM;

    

    bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();   
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump * 100));
        }

        if(Move != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        
        anim.SetBool("isJumping", !isGrounded());

        if(!isFacingRight && Move > 0)
        {
            Flip();
        }else if(isFacingRight && Move < 0)
        {
            Flip();
        }
    }

    public bool isGrounded()
    {
        if (Physics2D.BoxCast(transform.position, boxSide, 0, -transform.up, castDistance, groundLayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnDrawGizmos()
    {
       Gizmos.DrawWireCube(transform.position - transform.up * castDistance, boxSide);
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
  
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

    }
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Book"))
        {

            Destroy(other.gameObject);
            BM.BookCount++;

        }
    }


}



      


