using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToInteract : MonoBehaviour
{
    public float time;

    private void Start()
    {
        time = 5;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if(time >= 0)
        {
            time -= Time.deltaTime;
        }
        if(time <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
