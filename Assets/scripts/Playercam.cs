using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercam : MonoBehaviour
{
    public GameObject darkness;
   
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.gameObject.tag != "player" || other.transform.gameObject.tag != "sight")
        {
            darkness.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        darkness.SetActive(false);
    }
}
