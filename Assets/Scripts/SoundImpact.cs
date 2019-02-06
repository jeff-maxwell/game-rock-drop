using UnityEngine;

public class SoundImpact : MonoBehaviour
{
    private Score scoreScript = new Score();

    public AudioSource audioSource;    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals("Stone") == true)
        {
            //scoreScript.IncrementScore();
            audioSource.Play();
        }
    }
}
