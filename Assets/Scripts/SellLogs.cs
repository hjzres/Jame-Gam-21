using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellLogs : MonoBehaviour
{
    void sellLogs()
    {
        StaticData.money += StaticData.logs * 5;
        StaticData.logs = 0;
    }
}
