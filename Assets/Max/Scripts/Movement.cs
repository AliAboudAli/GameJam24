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
    bool animationPlaying;

    public GameObject Foot2;
    public GameObject Hand;
    public GameObject Hairymanfeet365;

    public bool IsAttacking = false;
    public bool IsKicking = false;
    public bool IsPunching = false;

    void Start()
    {

    }

    void Update()
    {
        {


            float verticalInput = Input.GetAxis("Vertical");

            Debug.Log("Vertical Input: " + verticalInput);

            Vector3 moveDirection = new Vector3(0f, 0f, verticalInput).normalized;

            controller = GetComponent<CharacterController>();

            if (animator.GetCurrentAnimatorStateInfo(0).length < animator.GetCurrentAnimatorStateInfo(0).normalizedTime)
            {
                Debug.Log("animation done");
                IsAttacking = false;
                IsKicking = false;
                IsPunching = false;
            }

            if (IsPunching)
            {
                Hand.SetActive(true);
            }

            if (!IsPunching)
            {
                Hand.SetActive(false);
            }

            if (IsKicking)
            {
                Hairymanfeet365.SetActive(true);
                Foot2.SetActive(true);
            }

            if (!IsKicking)
            {
                Hairymanfeet365.SetActive(false);
                Foot2.SetActive(false);
            }

            if (!IsAttacking)
            {
                controller.Move(moveDirection * moveSpeed * Time.deltaTime);
            }

            if (verticalInput == 0 && !IsAttacking)
            {
                animator.Play("Idle");
            }

            if (verticalInput == 1 && !IsAttacking)
            {
                animator.Play("WalkForward");
            }

            if (verticalInput == -1 && !IsAttacking)
            {
                animator.Play("WalkBackward");
            }

            if (Input.GetButtonDown("Fire1"))
            {
                IsPunching = true;
                IsAttacking = true;
                animator.Play("Punch");
            }

            if (Input.GetButtonDown("Fire2"))
            {
                IsKicking = true;
                IsAttacking = true;
                animator.Play("Mma Kick");
            }

            if (Input.GetButtonDown("Fire3"))
            {
                IsKicking = true;
                IsAttacking = true;
                animator.Play("Flying Bicycle Kick");
            }

            if (Input.GetButtonDown("Fire4"))
            {
                IsKicking = true;
                IsAttacking = true;
                animator.Play("Hurricane Kick");

            }
        }
    }
}
