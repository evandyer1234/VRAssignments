using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        ButtonScript bs = other.gameObject.GetComponent<ButtonScript>();
        if (bs != null)
        {
            bs.Spawn();
        }
    }
}
