using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Vehicle : MonoBehaviour
{

    public float speed = 1f;

    public Vector2 direction = Vector2.right;

    public Vector2 velocity = Vector2.zero;

    private Vector2 movementInput;

    private float leftEdge, rightEdge, topEdge, bottomEdge;

    // Start is called before the first frame update
    void Start()
    {
        //sets thes edges of the screen to the coordinates
        leftEdge = Camera.main.ScreenToWorldPoint(new Vector2(0,0)).x;
        rightEdge = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0)).x;
        topEdge = Camera.main.ScreenToWorldPoint(new Vector2(0,Screen.height)).y;
        bottomEdge = Camera.main.ScreenToWorldPoint(new Vector2(0,0)).y;
    }

    // Update is called once per frame
    void Update()
    {
        direction = movementInput;

        //Update velocity
        // Velocity is our direction, multiplied by our speed
        velocity = direction * speed * Time.deltaTime;
        
        //Add our velocity to our position
        transform.position += (Vector3)velocity;
        //stops vehicle from resetting facing position when not moving
        /*
        if(direction != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
        }
        */

        //wraps vehicle around edges once it corsses boundary
        if (transform.position.x < leftEdge)
        {
            transform.position = new Vector2(leftEdge, transform.position.y);
            //transform.position = new Vector2(bottomEdge, transform.position.y);
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.right);
            
        }
        if(transform.position.x > rightEdge)
        {
            transform.position = new Vector2(rightEdge, transform.position.y);
        }
        if (transform.position.y > topEdge)
        {
            transform.position = new Vector2(transform.position.x, topEdge);
        }
        if (transform.position.y < bottomEdge)
        {
            transform.position = new Vector2(transform.position.x, bottomEdge);
        }

        //bottom x axis movement
        /*
        if (transform.position.y == -4.35 && transform.position.x >= 7)
        {
            transform.position = new Vector2(7.3f, -3.1f);
            
        }
        */
        
        if (transform.position.y >= -4.35 && transform.position.x < 7)
        {
            transform.position = new Vector2(transform.position.x, -4.35f);
        }
        

        /*
        if (transform.position.y < -3 && transform.position.x == 7.3)
        {
            transform.position = new Vector2(6.9f, -4.35f);
        }
        */
        /*
        //right side movement
        if (transform.position.y >= -3 && transform.position.x == 7.3)
        {
            transform.position = new Vector2(7.3f, -3f);
        }
        
        if (transform.position.y >= -3 && transform.position.x > 7.3)
        {
            transform.position = new Vector2(7.3f, transform.position.y);
        }
        */
        
    }

    public void OnMove(InputAction.CallbackContext moveContext)
    {
        movementInput = moveContext.ReadValue<Vector2>();
    }
}
