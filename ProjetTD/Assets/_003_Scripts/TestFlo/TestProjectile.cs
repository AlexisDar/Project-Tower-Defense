using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProjectile : MonoBehaviour
{
    public TestEnnemi EnnemiHealth;
    public float _speed;
    public float Damage;
    
    
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemis"))
        {
            EnnemiHealth.currentHealth -= Damage;
        }
    }
}
