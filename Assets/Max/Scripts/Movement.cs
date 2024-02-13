using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    CharacterController controller; 

    public Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log("Vertical Input: " + verticalInput);

        Vector3 moveDirection = new Vector3(0f, 0f, verticalInput).normalized;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        if (verticalInput > 0)
        {
            animator.Play("WalkForward");
        }

        if (verticalInput < 0)
        {
            animator.Play("WalkBackward");
        }


        if (Input.GetButtonDown("Fire1"))
        {
            animator.Play("Punch");
        }
        if (!this.animator.GetCurrentAnimatorStateInfo(0).IsName("Punch") && verticalInput == 0)
        {
            animator.Play("Idle");
        }

    }
}
