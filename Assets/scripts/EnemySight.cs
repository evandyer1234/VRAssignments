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
    public Collider collider;
    bool reset = false;
    bool reset2 = false;

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
            if (!reset)
            {
                current = sighttime;
                enemy.alert = false;
                cg = gift;
                source.Pause();
                reset = true;
                reset2 = false;
            }
        }
        else
        {
            cg -= Time.fixedDeltaTime;
            if (cg <= 0)
            {
                if (!reset2)
                {
                    source.UnPause();
                    reset = false;
                    reset2 = true;
                }
            }
            current -= Time.fixedDeltaTime;
            if (current <= 0)
            {
                enemy.alert = false;
                alert = false;
                m.EndGame();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {       
        if (other.gameObject.tag == "player")
        {
            collider.enabled = false;
            Debug.Log("tag seen");
            RaycastHit hit;

            Vector3 pos = sight.transform.position;
            Vector3 dir = (other.gameObject.transform.position - pos).normalized;

            if (Physics.Raycast(pos, dir, out hit, Mathf.Infinity))
            {
                Debug.DrawRay(pos, dir * hit.distance, Color.yellow);
                Debug.Log("The name is " + hit.collider.gameObject.name);
                Debug.Log("The tag is " + hit.collider.gameObject.tag);
                if ( hit.collider.gameObject.tag == "MainCamera")
                {
                    
                    alert = true;
                    Debug.Log(enemy.gameObject.name + " is detecting");
                }
                else
                {
                    Debug.Log("the blocking objects tag is " + hit.collider.gameObject.tag);
                    Debug.Log("the blocking objects name is " + hit.collider.gameObject.name);

                    alert = false;
                }
            }

            collider.enabled = true;
        }
        else
        {
            alert = false;
            //source.Pause();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            alert = false;
            //source.Pause();
        }
    }
}
