using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public manager m;
    public GameObject spawnpoint;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            m.spawn = spawnpoint.transform.position;
        }
    }
}
