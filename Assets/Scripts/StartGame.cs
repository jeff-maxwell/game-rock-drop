using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public Transform character;
    //public Transform character;

    //public SpriteRenderer spriteRenderer;
    private AudioClip audioClip;

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
        var random = new Random();

        //var sprite = Resources.Load<Sprite>("Sprites/boyzombiehead");
        //spriteRenderer = character.GetComponent<SpriteRenderer>();

        //spriteRenderer.sprite = sprite;

        var x = Random.Range(-8.0f, 8.0f);
        var startPosition = new Vector3(x, -6, 0);
        character.position = startPosition;
        Instantiate(character);
    }
}
