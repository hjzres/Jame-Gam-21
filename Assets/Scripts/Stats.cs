using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [SerializeField] private Text _dexterity;
    [SerializeField] private Text _storage;
    [SerializeField] private Text _walkSpeed;
    [SerializeField] private Text _dexterityCost;
    [SerializeField] private Text _storageCost;
    [SerializeField] private Text _walkSpeedCost;


    private void Update()
    {
        _dexterity.text = StaticData.dexterity.ToString();
        _storage.text = StaticData.storage.ToString();
        _walkSpeed.text = StaticData.walkSpeed.ToString();
        _dexterityCost.text = StaticData.dexterityCost.ToString();
        _storageCost.text = StaticData.storageCost.ToString();
        _walkSpeedCost.text = StaticData.walkSpeedCost.ToString();

    }
}
