using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    bool alert = false;
    public GameObject sightspawn;
    public float sighttime = 3f;
    public float current;
    public manager m;
    void Start()
    {
        current = sighttime;
    }

    
    void Update()
    {
        if (!alert)
        {

        }
        else
        {
            current -= Time.fixedDeltaTime;
            if (current <= 0)
            {
                m.EndGame();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {       
        if (other.gameObject.tag == "player")
        {
            
            RaycastHit hit;

            Vector3 pos = sightspawn.transform.position;
            Vector3 dir = (pos - other.gameObject.transform.position).normalized;

            if (Physics.Raycast(pos, dir, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "player")
                {
                    alert = true;
                }
                else
                {
                    alert = false;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            alert = false;
        }
    }
}
