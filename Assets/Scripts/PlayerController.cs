/*
 * Developer: Jeff Maxwell
 * Class: Game Development
 * 
 * All visual assests were found on
 * https://www.gameart2d.com/free-platformer-game-tileset.html
 */

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Rigid2D tied to the Claw
    private Rigidbody2D rb;

    // Speed for the movement of the claw left and right
    public float speed = 0.0f;

    // Stone Prefab transform object
    public Transform stone;

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

        // If the key press is a SPACE drop a rock
        if (Input.GetKeyDown("space"))
        {
            // Initialize the rock transform to the game object transform
            Transform rockSpacing = this.transform;

            // Move the transform location of the rock
            rockSpacing.position.Set(rb.transform.position.x, 
                    rb.transform.position.y - 1, 
                    rb.transform.position.z);

            // Create a new instance of the Stone/Rock object
            Instantiate(stone, rockSpacing);
        }
    }
}
