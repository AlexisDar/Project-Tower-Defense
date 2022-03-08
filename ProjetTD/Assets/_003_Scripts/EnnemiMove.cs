using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnnemiMove : MonoBehaviour
{
    public float _speed;
    public PointDirection PDirec;
    private int PointDirectionIndex;

    // Start is called before the first frame update
    void Start()
    {
        PDirec = GameObject.FindGameObjectWithTag("PointsDirection").GetComponent<PointDirection>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PDirec.pointsDirection[PointDirectionIndex].position, _speed * Time.deltaTime);
    }


}
