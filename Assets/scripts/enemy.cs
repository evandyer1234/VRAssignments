using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent myNavMeshAgent;

    public WheelRotate leftwheel;
    public WheelRotate rightwheel;

    public bool alert = false;

    public float rotationrate = 100f;
    public float speed = 20f;  
}
