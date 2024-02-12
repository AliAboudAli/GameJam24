using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    CharacterController controller; // Reference to CharacterController component

    public Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Get reference to CharacterController component
    }

    void Update()
    {
        // Get input axis from Xbox controller
        float verticalInput = Input.GetAxis("Vertical");

        // Print input value to the console for debugging
        Debug.Log("Vertical Input: " + verticalInput);

        // Calculate movement vector
        Vector3 moveDirection = new Vector3(0f, 0f, verticalInput).normalized;

        // Move the character
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        if (verticalInput > 1)
        {
            animator.Play("WalkForward");
        }
    }


}
