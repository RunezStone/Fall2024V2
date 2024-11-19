using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timePassed;
       
    void Update()
    {
        if (timePassed <= 601)
        {
            timePassed += Time.deltaTime;
            
        }
        else if (timePassed > 601)
        {
            timePassed = 0;
        }

        int minutes = Mathf.FloorToInt(timePassed / 60);
        int seconds = Mathf.FloorToInt(timePassed % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
