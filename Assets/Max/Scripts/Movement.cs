using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    CharacterController controller; 

    public Animator animator;
    AnimatorStateInfo animStateInfo;
    public float NTime;
    bool animationFinished;

    public bool IsAttacking = false;
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log("Vertical Input: " + verticalInput);


   

        Vector3 moveDirection = new Vector3(0f, 0f, verticalInput).normalized;


        if (!IsAttacking)
        {
            controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        }

        if (verticalInput == 1 && animationFinished == true && !IsAttacking)
        {
            animator.Play("WalkForward");
        }

        if (verticalInput == -1 && !IsAttacking)
        {
            animator.Play("WalkBackward");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            IsAttacking = true;
            animator.Play("Punch");

            

       
        }

        animStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        NTime = animStateInfo.normalizedTime;

        if (NTime > 0.88f)
        {
            print("animation complete");
            animationFinished = true;
            IsAttacking = false;
        }

        /*if (!this.animator.GetCurrentAnimatorStateInfo(0).IsName("Punch") && verticalInput == 0)
        {
            animator.Play("Idle");
        }*/

        if (Input.GetButtonDown("Fire2"))
        {
            IsAttacking = true;
            animator.Play("Mma Kick");
        }

        /*if (!this.animator.GetCurrentAnimatorStateInfo(0).IsName("Mma Kick") && verticalInput == 0)
        {
            animator.Play("Idle");
        }*/

        if (Input.GetButtonDown("Fire3"))
        {
            IsAttacking = true;
            animator.Play("Flying Bicycle Kick");
        }

        /*if (!this.animator.GetCurrentAnimatorStateInfo(0).IsName("Hurricane Kick") && verticalInput == 0)
        {
            animator.Play("Idle");
        }*/
        
    }
}
