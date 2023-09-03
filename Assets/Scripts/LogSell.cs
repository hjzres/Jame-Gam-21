using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogSell : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            StaticData.money = StaticData.logs * 5;
            StaticData.logs = 0;
        }
    }
}
