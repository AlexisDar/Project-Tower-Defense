using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    

    public List<Transform> snapPoints;
    public List<Draggable> draggableObjects;
    public float snapRange = 0.5f;


    void Start()
    {
        foreach (Draggable draggable in draggableObjects)
        {
            draggable.dragEndedCallBack = OnDragEnded;
        }
    }

    public void OnDragEnded(Draggable dragDrop) 
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
            float currentDistance = Vector2.Distance(dragDrop.transform.localPosition, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            dragDrop.transform.localPosition = closestSnapPoint.localPosition;
        }

    }
}
