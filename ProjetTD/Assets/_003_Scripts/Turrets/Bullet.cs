using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    void Seek(Transform _target)
    {
        target = _target;
    }
}
