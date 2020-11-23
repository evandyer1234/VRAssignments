using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySight : MonoBehaviour
{
    bool alert = false;
    public GameObject sightspawn;
    public float sighttime = 3f;
    public float current;
    public manager m;
    public Enemy enemy;
    public GameObject spot;
    public LayerMask mask;
    public GameObject sight;
    public AudioSource source;
    public float gift = 0.2f;
    public float cg;

    void Start()
    {
        current = sighttime;
        cg = gift;
    }

    
    void Update()
    {
        gameObject.transform.position = spot.transform.position;
        gameObject.transform.rotation = spot.transform.rotation;

        if (!alert)
        {
            current = sighttime;
            enemy.alert = false;
            cg = gift;
        }
        else
        {
            cg -= Time.fixedDeltaTime;
            if (cg <= 0)
            {
                source.UnPause();

            }
            current -= Time.fixedDeltaTime;
            if (current <= 0)
            {
                enemy.alert = true;
                m.EndGame();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {       
        if (other.gameObject.tag == "player")
        {
            
            RaycastHit hit;

            Vector3 pos = sight.transform.position;
            Vector3 dir = (pos - other.gameObject.transform.position).normalized;

            if (Physics.Raycast(pos, dir, out hit, Mathf.Infinity, mask))
            {               
                alert = true;
                Debug.Log(enemy.gameObject.name);
            }
            else
            {
                alert = false;
                source.Pause();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            alert = false;
            source.Pause();
        }
    }
}
