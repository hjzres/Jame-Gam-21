using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    // These are the things that never will reset
    public static float money = 0; 
    public static int storage = 12;
    public static float dexterity = 1;
    public static int walkSpeed = 14;
    public static int day = 1;

    // These are the variables that are motified by the axe type
    public static int motifiedStorage = storage;
    public static float motifiedDexterity = dexterity;
    public static int motifiedWalkSpeed = walkSpeed;

    // Shop
    public static float dexterityCost = 40;
    public static float storageCost = 40;
    public static float walkSpeedCost = 40;

    public static int logs = 0;
    public static int axe = 7;
}
