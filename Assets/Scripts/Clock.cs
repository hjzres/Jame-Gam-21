using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] private Text text;
    public int seconds;
    [Header("Time")]
    public int hours;
    public int minutes;
    public string cycle;

    private float time;

    private void Start()
    {
        hours = 7;
        minutes = 0;
        cycle = "AM";
    }

    private void Update()
    {
        time += Time.deltaTime;
        if(time >= seconds/17/6)
        {
            minutes += 1;
            time = 0;
        }
        if(minutes > 5)
        {
            hours ++;
            minutes = 0;
        }
        if(hours > 11)
        {
            cycle = "PM";
        }
        if(hours > 12)
        {
            hours = 1;
        }

        text.text = hours + ":" + minutes + "0 " + cycle;
    }
}