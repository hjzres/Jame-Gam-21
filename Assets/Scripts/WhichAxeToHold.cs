using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichAxeToHold : MonoBehaviour
{
    public GameObject hold;
    private MeshRenderer item;
    public Material[] axes;

    private void Awake()
    {
        item = hold.GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if(StaticData.axe < 7)
        {
            hold.SetActive(true);
            item.material = axes[StaticData.axe];
        }
        else
        {
            hold.SetActive(false); 
        }
    }
}
