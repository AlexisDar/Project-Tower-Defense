using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    public GameObject projectile;
    private EnnemiMove target;
    private Queue<EnnemiMove> ennemis = new Queue<EnnemiMove>();
    private bool hasTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        Debug.Log(target);
        if (hasTarget)
        {
            Debug.Log("Pr�t � tirer!");
        }
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
            hasTarget = true;
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ennemis")
        {
            target = null;
            hasTarget = false;
        }
    }

}
