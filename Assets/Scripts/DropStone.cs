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
        if ((Input.GetKeyDown("space")) 
            || (Input.GetMouseButtonDown(0))
            || (Input.GetButtonDown("Fire1")))
        {
            // Initialize the rock transform to the game object transform
            Transform rockSpacing = this.transform;

            // Show the Open Claw
            spriteRenderer.sprite = clawOpen;

            // Set the Sorting Layer for the rock
            stone.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
            stone.GetComponent<SpriteRenderer>().sortingOrder = 10;

            stone.transform.parent = null;

            // Create a new instance of the Stone/Rock object
            Instantiate(stone, this.transform);

            // Once the stone is dropped remove the link to the parent
            stone.transform.parent = null;
        }

        // If the key released is SPACE close the Claw
        if ((Input.GetKeyUp("space")) 
            || (Input.GetMouseButtonUp(0))
            || (Input.GetButtonUp("Fire1")))
        {
            // Show the Closed Claw
            spriteRenderer.sprite = clawClosed;
        }
    }
}
