using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject item;
    public GameObject spawnpoint;
    
   
   
    public void Spawn()
    {
        GameObject clone;
        clone = Instantiate(item, spawnpoint.transform.position, Quaternion.identity);
    }
}
