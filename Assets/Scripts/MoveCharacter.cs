using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Speed for the movement of the claw left and right
    public float speed = 0.0f;

    // Default the direction to positive 1.0 UP
    private float direction = 1.0f;

    private void OnBecameInvisible()
    {
        // If the game object is no longer visible destory the object
        Destroy(this.gameObject);
    }

    void Update()
    {
        // If the position is >= -3 reverse the direction
        if (transform.position.y >= -3)
        {
            direction = -1.0f;
        }

        // Move the object
        var move = new Vector3(0.0f, 1, 0.0f);
        transform.position += move * direction * speed * Time.deltaTime;
    }
}
