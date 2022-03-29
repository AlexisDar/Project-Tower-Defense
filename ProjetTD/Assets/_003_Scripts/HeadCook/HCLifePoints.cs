using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HCLifePoints : MonoBehaviour
{
    public int HcCurrentLife;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (HcCurrentLife <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.CompareTag("Enemy"))
        {
        HcCurrentLife -= 1;
        }
    }
}
