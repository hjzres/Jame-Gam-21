using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    public static int money;
    public static int storage;
    public static int agility;

    private void Awake()
    {
        money = 0;
        storage = 12;
        agility = 1;
    }
}
