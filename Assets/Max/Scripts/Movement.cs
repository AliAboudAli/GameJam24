using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public CharacterController controller;

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

    public Vector3 moveDirection;
    public Vector3 P2moveDirection;

    void Start()
    {

    }

    void Update()
    {
          



        
        
        

        if (this.tag == ("P1"))
        {
                float verticalInput = Input.GetAxis("Vertical");
                moveDirection = new Vector3(verticalInput, 0f, 0f).normalized;
                
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
            if (gameObject.tag == ("P2"))
            {
                float P2verticalInput = Input.GetAxis("Vertical2");

                moveDirection = new Vector3(P2verticalInput, 0f, 0f).normalized;
                

                if (P2verticalInput == 0 && !IsAttacking)
                {
                    animator.Play("Idle");
                }

                if (P2verticalInput == 1 && !IsAttacking)
                {
                    animator.Play("WalkForward");
                }

                if (P2verticalInput == -1 && !IsAttacking)
                {
                    animator.Play("WalkBackward");
                }

                if (Input.GetButtonDown("P2Fire1"))
                {
                    Debug.Log("player2 fire1");
                    IsPunching = true;
                    IsAttacking = true;
                    animator.Play("Punch");
                }

                if (Input.GetButtonDown("P2Fire2"))
                {
                    Debug.Log("player2 fire1");
                    IsKicking = true;
                    IsAttacking = true;
                    animator.Play("Mma Kick");
                }

                if (Input.GetButtonDown("P2Fire3"))
                {
                    IsKicking = true;
                    IsAttacking = true;
                    animator.Play("Flying Bicycle Kick");
                }

                if (Input.GetButtonDown("P2Fire4"))
                {
                    IsKicking = true;
                    IsAttacking = true;
                    animator.Play("Hurricane Kick");
                }
            }

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

            /*if (!IsAttacking)
            {
                controller.Move(P2moveDirection * moveSpeed * Time.deltaTime);
            }*/
        }
    }

