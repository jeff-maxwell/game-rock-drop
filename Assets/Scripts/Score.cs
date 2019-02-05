using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;

    public void IncrementScore()
    {
        scoreText.text = $"Score: {++score}";
    }
}
