using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Data.SqlTypes;

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
        if(hours == 12 && cycle == "PM")
        {
            Reset();
        }
        else
        {
            time += Time.deltaTime;
            if (time >= seconds / 17 / 6)
            {
                minutes += 1;
                time = 0;
            }
            if (minutes > 5)
            {
                hours++;
                minutes = 0;
            }
            if (hours > 11)
            {
                cycle = "PM";
            }
            if (hours > 12)
            {
                hours = 1;
            }

            text.text = hours + ":" + minutes + "0 " + cycle;
        }
    }
    public void Reset()
    {
        Start();
        StaticData.day++;
        SceneManager.LoadScene(2);
        StaticData.motifiedDexterity = StaticData.dexterity;
        StaticData.motifiedStorage = StaticData.storage;
        StaticData.motifiedWalkSpeed = StaticData.walkSpeed;
        StaticData.logs = 0;
        StaticData.axe = 7;
    }
}
