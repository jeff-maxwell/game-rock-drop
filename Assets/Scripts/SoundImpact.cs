using UnityEngine;

public class SoundImpact : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
