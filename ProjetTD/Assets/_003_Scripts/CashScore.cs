using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashScore : MonoBehaviour
{

    public static int moneyValue = 0 ;
    Text money; 
    
    void Start()
    {
        money = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "Money:" + moneyValue;
    }

}
