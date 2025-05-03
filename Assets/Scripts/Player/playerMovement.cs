using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : Soundmaster
{
    public Collider2D myCollider;
    public Rigidbody2D rb;

    public bool isGrounded;
    public LayerMask whatIsGround;

    public float moveSpeed;
    public float jumpForce;
    private float HorMove = 0f;
    public bool isHacking = false;
    private bool right = true;

    public Transform trans;

    public InEnter ent;

    public DialogueManager dm;

    public Animator anim;

    void Update()
    {
        if (isHacking == false)
        {
            HorMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        }
        this.isGrounded = Physics2D.IsTouchingLayers(this.myCollider, this.whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && (isHacking == false))
        {
            if (this.isGrounded)
            {
                this.rb.velocity = new Vector2(this.rb.velocity.x, this.jumpForce);
                anim.SetTrigger("TakeOf");
                PlaySound(sound[0]);
            }
        }
        if ((isGrounded == true) && ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Idle", false);
            anim.SetBool("Running", true);
        }
        else if ((isGrounded == false) && ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Running", false);
            anim.SetBool("Idle", false);
            Debug.Log("falling");
        }
        else if (isGrounded == false)
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Running", false);
            anim.SetBool("Idle", false);
            Debug.Log("falling");
        }
        else
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Running", false);
            anim.SetBool("Idle", true);
        }

        if ((HorMove < 0) && right)
        {
            Flip();
        }
        if ((HorMove > 0) && !right)
        {
            Flip();
        }
        if (isHacking == true)
        {
            anim.SetBool("Working", true);
        }
        if (isHacking == false)
        {
            anim.SetBool("Working", false);
        }

    }

    private void FixedUpdate()
    {
        Vector2 tarVel = new Vector2(HorMove * 5f, rb.velocity.y);
        rb.velocity = tarVel;  // присваиваем скорость персонажу по х
    }

    void Flip() 
    {
        right = !right;
        Vector3 SprFlip = transform.localScale;
        SprFlip.x *= -1f;
        transform.localScale = SprFlip;
        
    }

    public void IsWork() 
    {
        isHacking = true;
    }
    public void StopWorking() 
    {
        isHacking = false;
    }
}
