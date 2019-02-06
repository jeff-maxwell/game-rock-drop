using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public GameObject character;
    //public Transform character;

    private Random random = new Random();

    void Start()
    {
        CreateCharacter();
    }

    void Update()
    {
        if (GameObject.Find("Character(Clone)") == null)
        {
            CreateCharacter();
        }

    }

    public void CreateCharacter()
    {
        Sprite sprite;
        AudioClip audioClip;

        var pickSprite = Random.Range(0, 4);

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
        //spriteRenderer = character.GetComponent<SpriteRenderer>();

        //spriteRenderer.sprite = sprite;

        character.GetComponent<AudioSource>().clip = audioClip;
        character.GetComponent<SpriteRenderer>().sprite = sprite;
        character.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
        character.GetComponent<SpriteRenderer>().sortingOrder = 0;

        var x = Random.Range(-8.0f, 8.0f);
        var startPosition = new Vector3(x, -6, 0);
        character.transform.position = startPosition;
        Instantiate(character);
    }
}
