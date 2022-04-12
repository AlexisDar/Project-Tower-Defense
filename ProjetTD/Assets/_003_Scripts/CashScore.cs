using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CashScore : MonoBehaviour
{
    public static CashScore Instance = null;
    public static int moneyValue = 0 ;
    public TMP_Text money; 
    
    void Awake()
    {
        // money = GetComponent<TMP_Text>();
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        money.text = $"Money: {moneyValue}";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddMoney(int _earnedMoney)
    {
        moneyValue += _earnedMoney;
        money.text = $"Money: {moneyValue}";

    }

}
