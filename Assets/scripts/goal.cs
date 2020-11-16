using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public doorscript ds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            if (ds.currentTarget == ds.Down)
            {
                ds.Close();
            }
            else
            {
                ds.Open();
            }
            Destroy(other.gameObject);
        }
    }
}
