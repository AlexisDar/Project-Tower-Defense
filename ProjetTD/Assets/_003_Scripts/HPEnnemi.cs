using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnnemi : MonoBehaviour
{
    public int pvEnnemi;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pvEnnemi <= 0)
        {
            CashScore.moneyValue += 10;
            Destroy(gameObject);
        }
    }

}
