using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour
{
    public GameObject Up;
    public GameObject Down;
    [HideInInspector]
    public GameObject currentTarget;
    public float currentSpeed;
    public bool HasDynamicDirection;
    Transform transf;
    Vector3 MoveDirection;
    public float WithinRange = .75f;

    void Start()
    {
        transf = gameObject.GetComponent<Transform>();
        currentTarget = Up;
        UpdateMovedirection();
    }

    void Update()
    {
        if (HasDynamicDirection)
        {

            UpdateMovedirection();
        }

        
        if (!IsCloseToTarget())
        {
            transf.position += (Time.deltaTime * MoveDirection * currentSpeed);

            //NextTarget();
            UpdateMovedirection();
        }
    }

    public bool IsCloseToTarget()
    {
        if (GetDistanceTo(currentTarget) < WithinRange)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public float GetDistanceTo(GameObject Other)
    {
        float distanceTo = (Other.transform.position - transform.position).magnitude;

        return distanceTo;
    }
    /*
    public void NextTarget()
    {
        if (PathListIndex < PathList.Capacity - 1)
        {
            PathListIndex++;
        }
        else
        {
            PathListIndex = 0;
        }
        currentTarget = PathList[PathListIndex];

    }
    */
    public void UpdateMovedirection()
    {
        MoveDirection = (currentTarget.transform.position - transf.position).normalized;
    }
    
    public void Open()
    {
        currentTarget = Down;
    }
    public void Close()
    {
        currentTarget = Up;
    }
}
