using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 playerVelocity;
    public bool groundedPlayer;
    private float jumpHeight = 2f;
    private float gravityValue = -9.81f;
    private CharacterController controller;
    private Animator animator;
    private float walkSpeed = 5;
    private float runSpeed = 8; 
    private int jumpCount = 0;
    public static bool powerUpTouch = false; 
 
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
       ProcessMovement();
       UpdateAnimator();
       
    }
    void DisableRootMotion()
    {
        animator.applyRootMotion = false;  
    }
    void UpdateAnimator()
    {
        // Do Roll
        if (Input.GetButtonDown("Fire2"))
        {
            animator.applyRootMotion = true; 
            animator.SetTrigger("DoFlip");
        }
        
        // Movement
        if (Mathf.Abs(Input.GetAxis("Horizontal"))>0.0f || Mathf.Abs(Input.GetAxis("Vertical"))>0.0f)
        {
            if (Input.GetButton("Fire3"))// Left shift
            {
                animator.SetFloat("CharacterSpeed",1.0f);
            }
            else
            {
                animator.SetFloat("CharacterSpeed",0.5f);
            }
        }
        else 
        {
            animator.SetFloat("CharacterSpeed",0.0f);

        }
        
        // Is Grounded
        animator.SetBool("isGrounded",groundedPlayer);
        
    }

    void ProcessMovement()
    { 
        // Moving the character foward according to the speed
        float speed = GetMovementSpeed();

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        // Turning the character
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        // Making sure we dont have a Y velocity if we are grounded
        // controller.isGrounded tells you if a character is grounded ( IE Touches the ground)
        groundedPlayer = controller.isGrounded;
        if (Input.GetButtonDown("Jump") && groundedPlayer && jumpCount==0)
        {
            animator.SetTrigger("Jump");
            
        }
        else if (Input.GetButtonUp("Jump") && groundedPlayer && jumpCount==0)
        {
               // Add the jump height to your up velocity; If jumping and grounded.
                  gravity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
                  jumpCount ++;
                  
        }
        else if(Input.GetButtonDown("Jump") && jumpCount<2 && !groundedPlayer && powerUpTouch == true)
        {
            gravity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            animator.SetTrigger("Flip");
            jumpCount ++;
        }
        else if (groundedPlayer)
        {
                    // Dont apply gravity if grounded and not jumping
                     gravity.y = -1.0f;
                     jumpCount = 0;
         }
        else
        {
                    // Since there is no physics applied on character controller we have this       applies to reapply gravity if the character is falling ( IE Not grounded )
                     gravity.y += gravityValue * Time.deltaTime;
        }  
        playerVelocity = gravity * Time.deltaTime + move * Time.deltaTime * speed;
        controller.Move(playerVelocity);
        
       
    }

    float GetMovementSpeed()
    {
        if (Input.GetButton("Fire3"))// Left shift
        {
            return runSpeed;
        }
        else
        {
            return walkSpeed;
        }
    }
}
