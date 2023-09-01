using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Doubloon : MonoBehaviour
{
    [SerializeField] private Text money;

    private void Update()
    {
        money.text = StaticData.money + "Ð";
    }
}
