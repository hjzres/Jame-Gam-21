using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopKeeper : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    [SerializeField] private int howManyAxes;
    [SerializeField] private Sprite[] axes;
    public string[] name, pros, cons;
    [SerializeField] private Text pros_text1, pros_text2, pros_text3, cons_Text_1, cons_Text_2, cons_Text_3;
    [SerializeField] private Image _axe1, _axe2, _axe3;
    public Text name1, name2, name3;
    [HideInInspector] public int axe1;
    [HideInInspector]  public int axe2;
    [HideInInspector] public int axe3;
    private int originalDayCount = 0;

    private void Awake()
    {
        
    }

    public void openShopMenu()
    {
        
        if(originalDayCount < StaticData.day)
        {
            ChooseAxe();
            UI.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            originalDayCount++;
        }
    }

    public void ChooseAxe()
    {
        axe1 = Random.Range(0, howManyAxes);
        axe2 = Random.Range(0, howManyAxes);
        axe3 = Random.Range(0, howManyAxes);

        while(axe2 == axe1)
        {
            axe2 = Random.Range(0, axes.Length - 1);
        }
        while(axe3 == axe1 || axe3 == axe2)
        {
            axe3 = Random.Range(0, axes.Length - 1);
        }

        print(axe1.ToString() + " " + axe2.ToString() + " " + axe3.ToString());

        _axe1.sprite = axes[axe1];
        _axe2.sprite = axes[axe2];
        _axe3.sprite = axes[axe3];

        name1.text = name[axe1];
        name2.text = name[axe2];
        name3.text = name[axe3];

        pros_text1.text = "Pro: " + pros[axe1];
        pros_text2.text = "Pro: " + pros[axe2];
        pros_text3.text = "Pro: " + pros[axe3];

        cons_Text_1.text = "Con: " + cons[axe1];
        cons_Text_2.text = "Con: " + cons[axe2];
        cons_Text_3.text = "Con: " + cons[axe3];
    }
}
