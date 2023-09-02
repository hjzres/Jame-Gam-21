using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchyGuy : MonoBehaviour
{
    [SerializeField] GameObject UI;

    public void openDealerMenu()
    {
        UI.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }
}
