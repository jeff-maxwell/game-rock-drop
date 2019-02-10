using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Game Object to for Characters
    public GameObject character;

    // Create instance of Random class
    // Used to randomly show characters
    private Random random = new Random();

    void Start()
    {
        // At the start of the game create the inial character
        CreateCharacter();
    }

    void Update()
    {
        // If there are no characters in the game create one
        if (GameObject.Find("Character(Clone)") == null)
        {
            CreateCharacter();
        }

    }

    public void CreateCharacter()
    {
        Sprite sprite;
        AudioClip audioClip;

        // Create a random number to pick a character
        var pickSprite = Random.Range(0, 4);

        // Depending on the random number update the sprite and audio
        // for the character
        if (pickSprite == 1)
        {
            sprite = Resources.Load<Sprite>("Sprites/boyzombiehead");
            audioClip = Resources.Load<AudioClip>("Audio/zombieboy");
        }
        else if (pickSprite == 2)
        {
            sprite = Resources.Load<Sprite>("Sprites/girlzombiehead");
            audioClip = Resources.Load<AudioClip>("Audio/zombiegirl");
        }
        else
        {
            sprite = Resources.Load<Sprite>("Sprites/santahead");
            audioClip = Resources.Load<AudioClip>("Audio/santa");
        }

        // Set the audio clip for the character
        character.GetComponent<AudioSource>().clip = audioClip;

        // Set the sprite for the character
        character.GetComponent<SpriteRenderer>().sprite = sprite;

        // Adjust the sorting layer and order to show the character above
        // the background
        character.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
        character.GetComponent<SpriteRenderer>().sortingOrder = 0;

        // Randomly pick an X value to show the character
        var x = Random.Range(-8.0f, 8.0f);

        // Start the character below the game surface
        var startPosition = new Vector3(x, -6, 0);
        character.transform.position = startPosition;

        // Add the character to the game
        Instantiate(character);
    }
}
