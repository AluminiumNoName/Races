using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool hasFinished;
    float minutes;
    float seconds;

    public TextMeshProUGUI timerText;

    private void Update()
    {
        if (hasFinished)
        {

        }
        else
        {
            seconds += Time.deltaTime;
            if (seconds >= 60)
            {
                seconds -= 60;
                minutes += 1;
            }

        }
            int m = Mathf.RoundToInt(minutes);
            int s = Mathf.RoundToInt(seconds);

        timerText.text = m.ToString() + ":" + s.ToString();
    }
}
