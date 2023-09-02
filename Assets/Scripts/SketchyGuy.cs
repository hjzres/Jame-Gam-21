using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchyGuy : MonoBehaviour
{
    [SerializeField] GameObject UI;

    private void Awake()
    {
        UI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            UI.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
