using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    public GameObject projectile;
    private EnnemiMove target;
    private Queue<EnnemiMove> ennemis = new Queue<EnnemiMove>();
    private bool hasTarget;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        Attack();
        Debug.Log(target);
        if (hasTarget)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Debug.Log("Prêt à tirer!");
                Instantiate(projectile, transform.position, Quaternion.Euler(transform.right));
                timer = 0.5f;
            }
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
