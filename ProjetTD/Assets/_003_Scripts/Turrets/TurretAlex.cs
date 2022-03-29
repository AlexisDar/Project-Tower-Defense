using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAlex : MonoBehaviour
{
    public Transform target;
    public float range = 3f;

    public string enemyTag = "Enemy";
    public Transform partToRotate;

    private float turnSpeed = 10;

    public float fireRate = 1f;
    private float fireCountDown =0f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    
    


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget" ,0f, 0.5f) ;
    }

    void UpdateTarget()
    {
        
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in ennemies)
        {
       
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            Debug.Log("target");
            target = nearestEnemy.transform;
        }

        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime* turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountDown <= 0)
        {
            Shoot();
            fireCountDown = 1 / fireRate;
        }

        fireCountDown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {

        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, range); 
    }
}