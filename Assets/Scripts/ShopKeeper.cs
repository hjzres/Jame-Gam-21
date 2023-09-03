using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopKeeper : MonoBehaviour
{
    [SerializeField] private GameObject UI;
    [SerializeField] private Texture[] axe;
    [SerializeField] private string[] prosAxe1, prosAxe2, prosAxe3, consAxe1, consAxe2, consAxe3;
    [SerializeField] private Text pros_text, cons_Text;
    [SerializeField] private Image _axe1, _axe2, _axe3;
    private int axe1;
    private int axe2;
    private int axe3;

    public void openShopMenu()
    {
        UI.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ChooseAxe()
    {
        axe1 = Random.Range(0, axe.Length - 1);
        axe2 = Random.Range(0, axe.Length - 1);
        axe3 = Random.Range(0, axe.Length - 1);

        if(axe2 == axe1)
        {
            axe2 = Random.Range(0, axe.Length - 1);
        }
        if(axe3 == axe1 || axe3 == axe2)
        {
            axe3 = Random.Range(0, axe.Length - 1);
        }

        Debug.Log(axe1.ToString() + axe2.ToString() + axe3.ToString());
    }
}
