using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogPickup : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "log")
        {
            Destroy(other.gameObject);
        }
    }
}
