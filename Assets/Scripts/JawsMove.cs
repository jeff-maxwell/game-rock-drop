using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawsMove : MonoBehaviour
{
    // Rigid2D tied to the Claw
    private Rigidbody2D rb;

    // Speed for the movement of the claw left and right
    public float speed = 0.0f;
    
    void Start()
    {
        // Get a reference to the Rigid body associated with the script
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Get movement value in the Horizontal direction
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Create a vector object with the Horizontal move
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        // Add force to the rigid body with them move times the speed
        rb.AddForce(movement * speed);
    }
}
