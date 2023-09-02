using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [SerializeField] private Text _dexterity;
    [SerializeField] private Text _storage;
    [SerializeField] private Text _walkSpeed;

    private void Update()
    {
        _dexterity.text = StaticData.dexterity.ToString();
        _storage.text = StaticData.storage.ToString();
        _walkSpeed.text = StaticData.walkSpeed.ToString();
    }
}
