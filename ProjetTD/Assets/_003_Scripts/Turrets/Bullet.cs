using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public int damage = 10;

    public float speed = 70f;

    public void Seek(Transform _target)
    {
        target = _target;
    }






    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
        }


        else if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            float distanceThisFrame = speed * Time.deltaTime;

            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
            }

            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        }
        else return;


    }



    void HitTarget()
    {
        Destroy(gameObject);
    }
}
