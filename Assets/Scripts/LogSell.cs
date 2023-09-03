using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogSell : MonoBehaviour
{
    private int pricePerLog = 2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            StaticData.money += StaticData.logs * pricePerLog;
            StaticData.logs = 0;
        }
    }
}
