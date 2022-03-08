using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnnemiMove : MonoBehaviour
{
    public float _speed;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
