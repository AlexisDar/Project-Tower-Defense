using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    public GameObject projectile;
    private EnnemiMove target;
    private Queue<EnnemiMove> ennemis = new Queue<EnnemiMove>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Debug.Log(target);
    }

    private void Attack()
    {
        if (target == null && ennemis.Count > 0)
        {
            target = ennemis.Dequeue();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ennemis")
        {
            ennemis.Enqueue(other.GetComponent<EnnemiMove>());
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ennemis")
        {
            target = null;
        }
    }

}
