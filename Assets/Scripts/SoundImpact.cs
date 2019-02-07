using UnityEngine;

public class SoundImpact : MonoBehaviour
{
    public Score scoreScript = new Score();

    public AudioSource audioSource;    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Stone"))
        {
            GameObject canvas = GameObject.FindWithTag("MainCanvas");

            scoreScript = canvas.GetComponent<Score>();
            scoreScript.IncrementScore();
            audioSource.Play();

            collision.gameObject.transform.parent = null;
            collision.gameObject.tag = "DroppedStone";
        }
    }
}
