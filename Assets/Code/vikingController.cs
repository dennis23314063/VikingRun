using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class vikingController : MonoBehaviour
{
    private CharacterController characterController;
    private Bridge bridge;
    private VikingInput input;
    private Animator animator;
    [SerializeField] float speed;
    private Vector2 realInput, jumpInput;
    private Vector3 transformed;
    private float angle;
    private float g = 40f;
    private float initialVerticalSpeed = 15f;
    private float verticalSpeed;
    public bool canRotate;
    public bool inRotatePoint;
    public bool fixDirection;
    public bool isGameStart;
    public bool isDie;
    // Start is called before the first frame update
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        input = new VikingInput();
        input.vikingInput.Move.started += MovementInput;
        input.vikingInput.Move.canceled += MovementInput;
        input.vikingInput.Move.performed += MovementInput;
        input.vikingInput.Jump.started += JumpInput;
        input.vikingInput.Jump.canceled += JumpInput;
    }
    private void MovementInput(InputAction.CallbackContext context)
    {
        realInput = context.ReadValue<Vector2>();
        transformed.x = realInput.x;
        transformed.z = realInput.y;
    }
    private void JumpInput(InputAction.CallbackContext context)
    {
        jumpInput = context.ReadValue<Vector2>();
        
    }
    private void Jump()
    {
        if (jumpInput.y!=0&&characterController.isGrounded)
        {
            verticalSpeed = initialVerticalSpeed;
            animator.SetBool("Jumping",true);
            
        }
        else if(characterController.isGrounded)
        {
            animator.SetBool("Jumping", false);
        }
    }
    public void Die()
    {
        input.vikingInput.Disable();
        animator.SetBool("Jumping",false);
        animator.SetBool("Running",false);
        animator.SetBool("Die", true);
        isDie = true;
        GameManager.Instance.isDie = true;
        speed = 0;  
        verticalSpeed = 0f;
        
    }
    private void Gravity()
    {
        if (jumpInput.y==0&&characterController.isGrounded)
            verticalSpeed = 0f;
        else
        {
            verticalSpeed -= g * Time.deltaTime;
        }
        transformed.y = verticalSpeed;
    }
    private void OnEnable()
    {
        input.vikingInput.Enable();
    }
    private void OnDisable()
    {
        input.vikingInput.Disable();
    }
    public void Rotate()
    {
        if (isGameStart)
        {
            if (fixDirection && canRotate && transformed.x != 0 && checkAngle(characterController.transform.eulerAngles.y))
            {
                characterController.transform.rotation = Quaternion.Euler(0, angle, 0);
                angle += transformed.x * 90;
                angle = angle >= 360 ? angle - 360 : angle;
                angle = angle < 0 ? angle + 360 : angle;
                fixDirection = false;
            }
            characterController.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, angle, 0), 15f * Time.deltaTime);
        }
        else
        {
            characterController.transform.Rotate(0,transformed.x,0);
        }
        
    }
    private bool checkAngle(float a)
    {
        return Mathf.Floor(a) == angle || Mathf.Ceil(a) == angle;
    }
    public void GameStart()
    {
        animator.SetBool("Running", true);
        animator.SetBool("Jumping", false);
        speed = 10f;
        angle = 0;
        canRotate = false;
        inRotatePoint = false;
        fixDirection = false;
        isDie = false;
        isGameStart = true;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        bridge = FindObjectOfType<Bridge>();
        animator.SetBool("Running",false);
        animator.SetBool("Jumping",false);
        speed = 10f;
        angle = 0;
        canRotate = false;
        inRotatePoint = false;
        fixDirection = false;
        isGameStart = false;
        isDie = false;
    }
    void Update()
    {
        Jump();
        Gravity();
        if (isGameStart)
        {
            
            characterController.Move(speed * Time.deltaTime * transform.forward);
            if (characterController.transform.position.y < 0) {
                Die();
            }
        }
        else {
            characterController.Move(speed * Time.deltaTime * transform.forward*realInput.y);
            animator.SetBool("Running",realInput.y!=0);
            
        }
        characterController.Move(Time.deltaTime * new Vector2(0, transformed.y));
        Rotate();
    }
}
