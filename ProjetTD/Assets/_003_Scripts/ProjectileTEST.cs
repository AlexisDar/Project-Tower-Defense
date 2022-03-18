using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTEST : MonoBehaviour
{
    public float speed;
    public int projectileDamage = 20;
    private HPEnnemi hpEnnemi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemis"))
        {
            hpEnnemi = collision.gameObject.GetComponent<HPEnnemi>();
            hpEnnemi.pvEnnemi -= projectileDamage;
            Destroy(gameObject);
        }

    }

}
