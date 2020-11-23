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

    public EnemySight enemySight;
    public GameObject sightspawn;
    public GameObject sight;

    public manager m;

    public AudioSource source;
    

    void Start()
    {
        source.Play();
        source.Pause();
        EnemySight clone;
        clone = Instantiate(enemySight, sightspawn.transform.position, sightspawn.transform.rotation);
        clone.enemy = this;
        clone.spot = sightspawn;
        clone.m = m;
        clone.sight = sight;
        clone.source = source;
    }
}


