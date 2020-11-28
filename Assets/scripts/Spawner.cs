using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Item thing;
    public Transform spawnpoint;

    void Start()
    {
        Spawn();
    }

   
    public void Spawn()
    {
        Item clone;
        clone = Instantiate(thing, spawnpoint.transform.position, spawnpoint.transform.rotation);
        clone.spawner = this;
    }
}
