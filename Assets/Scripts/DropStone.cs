using UnityEngine;

public class DropStone : MonoBehaviour
{
    // Stone Prefab transform object
    public Transform stone;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        // If the key press is a SPACE drop a rock
        if (Input.GetKeyDown("space"))
        {
            // Initialize the rock transform to the game object transform
            Transform rockSpacing = this.transform;

            // Move the transform location of the rock
//            rockSpacing.position.Set(rb.transform.position.x,
//                    rb.transform.position.y - 1,
//                    rb.transform.position.z);

            stone.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
            stone.GetComponent<SpriteRenderer>().sortingOrder = 5;

            // Create a new instance of the Stone/Rock object
            Instantiate(stone, this.transform);
        }
    }
}
