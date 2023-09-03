using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] private int scene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player" && StaticData.axe != 7) 
        {
            SceneManager.LoadScene(scene);
        }
    }
}
