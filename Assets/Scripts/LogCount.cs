using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogCount : MonoBehaviour
{
    public int amount;
    [SerializeField] Text text;

    private void Update()
    {
        amount = StaticData.logs;
        text.text = amount.ToString();
    }
}