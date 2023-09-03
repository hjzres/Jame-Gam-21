using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject keeper;
    private ShopKeeper shopkeeper;


    private void Awake()
    {
        shopkeeper = keeper.GetComponent<ShopKeeper>();
    }

    public void Dexterity()
    {
        if (StaticData.money >= StaticData.dexterityCost)
        {
            StaticData.dexterity++;
            StaticData.motifiedDexterity++;
            StaticData.money -= StaticData.dexterityCost;
            StaticData.dexterityCost *= 1.5f;
        }
    }
    public void Storage()
    {
        if (StaticData.money >= StaticData.storageCost)
        {
            StaticData.storage += StaticData.storage / 4;
            StaticData.money -= StaticData.storageCost;
            StaticData.storageCost *= 1.5f;
        }
    }
    public void WalkSpeed()
    {
        if (StaticData.money >= StaticData.walkSpeedCost)
        {
            StaticData.walkSpeed++;
            StaticData.motifiedWalkSpeed++;
            StaticData.money -= StaticData.walkSpeedCost;
            StaticData.walkSpeedCost *= 1.5f;
        }
    }

    public void Exit(string title)
    {
        Time.timeScale=1.0f;
        GameObject.Find(title).SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void AxeChosen(int axeNum)
    {
        if(axeNum == 1)
        {
            StaticData.axe = shopkeeper.axe1;
        }
        if(axeNum == 2)
        {
            StaticData.axe = shopkeeper.axe2;
        }
        if(axeNum == 3)
        {
            StaticData.axe = shopkeeper.axe3;
        }
        print(StaticData.axe);
    }

}
