using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    [SerializeField] private Text text;
    public int hours { get; private set; }
    public int minutes { get; private set; }

    private float time;

    private void Start()
    {
        hours = 7;
        minutes = 0;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if(time >= 17.64705882352941)
        {
            minutes += 1;
            time = 0;
        }
        if(minutes > 5)
        {
            hours ++;
            minutes = 0;
        }

        text.text = hours + ":" + minutes + "0";
    }
}
