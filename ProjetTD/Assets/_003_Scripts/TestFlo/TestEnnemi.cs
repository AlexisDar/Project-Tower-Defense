using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnnemi : MonoBehaviour
{
    public float _speed;
    public float currentHealth;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * Time.deltaTime * _speed);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
