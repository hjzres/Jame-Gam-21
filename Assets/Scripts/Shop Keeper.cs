using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : MonoBehaviour
{
    public GameObject UI;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {

        }
    }
}
