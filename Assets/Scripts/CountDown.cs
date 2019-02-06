using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int timeLeft = 120;
    public Text timeLeftText;

    void Start()
    {
        StartCoroutine("DecreaseTime");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeftText.text = $"Time Left: {FormatTime()}";
    }

    private string FormatTime()
    {
        string minutes = (timeLeft / 60).ToString();
        string seconds = (timeLeft % 60).ToString();
        seconds = seconds.PadLeft(2, '0');

        return $"{minutes}:{seconds}";
    }

    IEnumerator DecreaseTime()
    {
        while (true)
        {
            if (timeLeft >= 0)
            {
                yield return new WaitForSeconds(1);
                timeLeft--;
            }
        }
    }
}
