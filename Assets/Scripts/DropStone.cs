using UnityEngine;

public class DropStone : MonoBehaviour
{
    // Stone Prefab transform object
    public Transform stone;

    // Closed Claw Sprite
    public Sprite clawClosed;

    // Open Claw Sprite
    public Sprite clawOpen;

    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        // If the key press is a SPACE open the Claw drop a rock
        if (Input.GetKeyDown("space"))
        {
            // Initialize the rock transform to the game object transform
            Transform rockSpacing = this.transform;

            // Show the Open Claw
            spriteRenderer.sprite = clawOpen;

            // Set the Sorting Layer for the rock
            stone.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
            stone.GetComponent<SpriteRenderer>().sortingOrder = 5;

            // Create a new instance of the Stone/Rock object
            Instantiate(stone, this.transform);
        }

        // If the key released is SPACE close the Claw
        if (Input.GetKeyUp("space"))
        {
            // Show the Closed Claw
            spriteRenderer.sprite = clawClosed;
        }
    }
}
