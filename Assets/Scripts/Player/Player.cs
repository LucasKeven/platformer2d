using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [Header("Rigibody")]
    public Rigidbody2D myRigidbody;

    [Header("Character Friction")]
    public Vector2 friction = new Vector2(0.1f, 0);    

    [Header("Movement")]
    public float speed;
    public float speedRun;

    [Header("Jump")]
    public float forceJump = 2;

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
    }
}
