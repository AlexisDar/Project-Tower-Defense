using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnnemiMove : MonoBehaviour
{
    public float _speed;
    private PointDirection PDirec;
    private int PointDirectionIndex;

    // Start is called before the first frame update
    void Start()
    {
        // Assoier la variable PDirect aux points de direction
        PDirec = GameObject.FindGameObjectWithTag("PointsDirection").GetComponent<PointDirection>();

    }

    // Update is called once per frame
    void Update()
    {
        // Faire se déplacer l'ennemi vers le 1er point de direction
        transform.position = Vector2.MoveTowards(transform.position, PDirec.pointsDirection[PointDirectionIndex].position, _speed * Time.deltaTime);
        
        // Faire se déplacer l'ennemi vers les points de direction suivants s'il atteint le point de direction actuel
        if(Vector2.Distance(transform.position , PDirec.pointsDirection[PointDirectionIndex].position) < 0.1f)
        {
            // Passer au point de direction suivant tant qu'il y en a un
            if(PointDirectionIndex < PDirec.pointsDirection.Length - 1)
            {
                PointDirectionIndex++;
            }
            // Détruire l'ennemi s'il arrive au dernier point de direction
            else
            {
                Destroy(gameObject);
            }
        }

    }


}
