using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Speed for the movement of the claw left and right
    public float speed = 0.0f;

    private float direction = 1.0f;

    void Start()
    {

    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
        if (transform.position.y >= -3)
        {
            direction = -1.0f;
        }

        var move = new Vector3(0.0f, 1, 0.0f);
        transform.position += move * direction * speed * Time.deltaTime;
    }
}
