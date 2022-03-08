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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectiles"))
        {
            ProjectileTEST projectileTEST = GetComponent<ProjectileTEST>();
            int damageDealing = projectileTEST.projectileDamage;

            pvEnnemi = pvEnnemi - damageDealing; 
        }


    }
}
