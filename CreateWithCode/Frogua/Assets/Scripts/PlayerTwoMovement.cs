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

    bool jump = false;
    bool crouch = false;

    public float mass = 1f;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        rb.mass = mass;


        if (gameManager.gameHasEnded == false)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
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
