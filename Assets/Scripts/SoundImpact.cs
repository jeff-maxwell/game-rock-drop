using UnityEngine;

public class SoundImpact : MonoBehaviour
{
    // Create an instance of the Score script
    private Score scoreScript = new Score();

    // Set a reference to the audio source
    public AudioSource audioSource;    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the object impacted is a Stone
        if (collision.gameObject.tag.Equals("Stone"))
        {
            // Find the Canvas object
            GameObject canvas = GameObject.FindWithTag("MainCanvas");

            // Call the IncrementScore
            scoreScript = canvas.GetComponent<Score>();
            scoreScript.IncrementScore();

            // Play the audio associated with the character
            audioSource.Play();

            // Remove the link to the parent
            collision.gameObject.transform.parent = null;

            // Rename the object tag
            collision.gameObject.tag = "DroppedStone";
        }
    }
}
