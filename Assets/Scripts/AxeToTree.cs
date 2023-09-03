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
                break;
            case 1:
                treeinteract.health = 1;
                StaticData.motifiedWalkSpeed = StaticData.walkSpeed / 3;
                break;
            case 2:
                StaticData.motifiedDexterity = StaticData.dexterity / 5;
                break;
            case 3:
                StaticData.motifiedDexterity = StaticData.dexterity * 5;
                break;
        }
    }
}
