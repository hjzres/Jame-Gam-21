using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AxeToTree : MonoBehaviour
{
    private TreeInteract treeinteract;

    private void Awake()
    {
        treeinteract = GetComponent<TreeInteract>();
        
    }

    private void Update()
    {
        switch (StaticData.axe)
        {
            case 0:
                treeinteract.health = 3;
                break;
            case 1:
                treeinteract.health = 1;
                StaticData.motifiedWalkSpeed = StaticData.walkSpeed/2;
                break;
        }
    }
}
