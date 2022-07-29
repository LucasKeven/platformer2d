using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{   
    [Header("Rigibody")]
    public Rigidbody2D myRigidbody;

    [Header("Character Movement Settup")]
    public Vector2 friction = new Vector2(0.1f, 0);
    public float speed;
    public float speedRun;
    public float forceJump = 2;

    [Header("Animation Settup")]
    public float jumpScaley = 1.5f;
    public float animationDuration = .3f;

    [Header("")]
    private float _currentSpeed;

    void Start()
    {
        
    }
    
    void Update()
    {
        HandleMovement();
        HandleJump();
    }

    public void HandleMovement()
    {

        if (Input.GetKey(KeyCode.LeftShift))            
                _currentSpeed = speedRun;
            else
                _currentSpeed = speed;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //myRigidbody.MovePosition(myRigidbody.position - velocity * Time.deltaTime);
            myRigidbody.velocity = new Vector2(- _currentSpeed, myRigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //myRigidbody.MovePosition(myRigidbody.position + velocity * Time.deltaTime);
            myRigidbody.velocity = new Vector2(_currentSpeed, myRigidbody.velocity.y);
        }

        //

        if (myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity += friction;
        }
        else if (myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity -= friction;
        }
    }

    public void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            myRigidbody.velocity = Vector2.up * forceJump;
            HandleScaleJump();
    }

    private void HandleScaleJump()
    {
        myRigidbody.transform.DOScaleY(jumpScaley, animationDuration).SetLoops(2, LoopType.Yoyo);
    }
}
