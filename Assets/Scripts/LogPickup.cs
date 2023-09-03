using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "log" && StaticData.logs < StaticData.storage)
        {
            StaticData.logs++;
            Destroy(other.gameObject);
        }
    }
}
