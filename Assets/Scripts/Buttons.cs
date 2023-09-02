using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void Dexterity()
    {
        StaticData.dexterity++;
    }
    public void Storage()
    {
        StaticData.storage+=StaticData.storage/4;
    }
    public void WalkSpeed()
    {
        StaticData.walkSpeed++;
    }

    public void Exit(string title)
    {
        Time.timeScale=1.0f;
        GameObject.Find(title).SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

    }

}
