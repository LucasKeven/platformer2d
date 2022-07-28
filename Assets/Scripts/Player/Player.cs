using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public Rigidbody2D myRigidbody;
    public Vector2 friction = new Vector2(.1f, 0);
    public Vector2 velocity;
    public float speed;
    public float forceJump = 100;
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
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //myRigidbody.MovePosition(myRigidbody.position - velocity * Time.deltaTime);
            myRigidbody.velocity = new Vector2(-speed, myRigidbody.velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            //myRigidbody.MovePosition(myRigidbody.position + velocity * Time.deltaTime);
            myRigidbody.velocity = new Vector2(+speed, myRigidbody.velocity.y);
        }

        //

        if(myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity -= friction;
        }
        else if(myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity += friction;
        }
    }

    public void HandleJump()
    {
        if(Input.GetKey(KeyCode.Space))
            myRigidbody.velocity = Vector2.up * forceJump;
    }
}
