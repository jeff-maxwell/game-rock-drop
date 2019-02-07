using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawsMove : MonoBehaviour
{
    // Speed for the movement of the claw left and right
    public float speed = 0.0f;
    
    void Start()
    {

    }

    void Update()
    {
        // Get movement value in the Horizontal direction
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        // Create a vector object with the Horizontal move
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        // Move the position of the object times the speed
        var move = new Vector3(moveHorizontal, 0.0f, 0.0f);
        transform.position += move * speed * Time.deltaTime;
    }
}
