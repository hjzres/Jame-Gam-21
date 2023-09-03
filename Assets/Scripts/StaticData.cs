using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    // These are the things that never will reset
    public static float money = 0; 
    public static int storage = 12;
    public static int dexterity = 1;
    public static int walkSpeed = 14;
    public static int day = 1;

    // These are the variables that are motified by the axe type
    public static int motifiedStorage;
    public static int motifiedDexterity;
    public static int motifiedWalkSpeed;

    // Shop
    public static float dexterityCost = 40;
    public static float storageCost = 40;
    public static float walkSpeedCost = 40;

    public static int logs = 0;
    public static int axe = 7;

    public void Update()
    {
        print("test");
    }
}
