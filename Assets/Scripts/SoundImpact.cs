using UnityEngine;

public class SoundImpact : MonoBehaviour
{
    public AudioClip audioClip;
    private Score scoreScript = new Score();

    private AudioSource audioSource;    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreScript.IncrementScore();
        audioSource.PlayOneShot(audioClip);
    }
}
