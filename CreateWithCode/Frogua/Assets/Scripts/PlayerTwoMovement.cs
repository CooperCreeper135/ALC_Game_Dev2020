using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    public Animator animator;

    float horizontalMove = 0f;

    public Rigidbody2D rb;

    public GameManager gameManager;
    private Climbing coll;
    bool jump = false;
    bool crouch = false;
    public float speed = 10;
    public int side = 1;
    public float mass = 1f;
    public bool wallGrab;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Climbing>();
    }

    void Update()
    {
        rb.mass = mass;
        float y = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        if (gameManager.gameHasEnded == false)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
            if (coll.onWall){
                //if(side != coll.wallSide)
                    //flip animation
                wallGrab = true;
                
            }
            else{
                wallGrab = false;
            }
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
            if(x > 0)
            {
                side = -1;
                
            }
            if (x < 0)
            {
                side = 1;
                
            }
            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
                mass = 8f;

            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
                mass = 1f;
            }
            if (wallGrab){
                rb.gravityScale = 0f;
                
                animator.SetBool("IsHanging", true);
                animator.SetBool("IsJumping", false);
                if(x > .2f || x < -.2f)
                rb.velocity = new Vector2(rb.velocity.x, 0);

                float speedModifier = y > 0 ? .5f : 1;

                rb.velocity = new Vector2(rb.velocity.x, y * (speed * speedModifier));
            }
            else
            {
                animator.SetBool("IsHanging", false);
                rb.gravityScale = 3f;
            }
        }
            

    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching); 
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
