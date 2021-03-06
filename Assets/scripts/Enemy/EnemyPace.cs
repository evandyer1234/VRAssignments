﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPace : Enemy
{
    public List<GameObject> points = new List<GameObject>();
    public int listindex = 0;
    public float distance = 1f;

    private void Awake()
    {
        myNavMeshAgent.SetDestination(points[listindex].transform.position);
    }
    private void FixedUpdate()
    {
        leftwheel.Spin(180f);
        rightwheel.Spin(-180f);
    }
    void Update()
    {
        
        if (myNavMeshAgent.destination == null)
        {
            myNavMeshAgent.SetDestination(points[listindex].transform.position);
        }
        if (!alert)
        {
            myNavMeshAgent.enabled = true;
            myNavMeshAgent.SetDestination(points[listindex].transform.position);
            if (Vector3.Distance(transform.position, points[listindex].transform.position) < distance)
            {
                Next();
            }
        }
        if (alert)
        {
            myNavMeshAgent.enabled = false;
        }
    }
    public void Next()
    {
        if (listindex + 1 < points.Capacity)
        {
            listindex++;            
        }
        else
        {
            listindex = 0;
        }
        myNavMeshAgent.SetDestination(points[listindex].transform.position);
    }
}
