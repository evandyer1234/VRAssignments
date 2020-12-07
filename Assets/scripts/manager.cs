using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public Vector3 spawn;
    public checkpoint defaultspawn;
    public Graphic black;
    bool dying = false;
    float dark = 0;
    public float rate = 10f;
    public GameObject player;
    public float deathtime = 3f;
    float current;
    public ListExchange le;

    private void Start()
    {
        if (defaultspawn != null)
        {
            spawn = defaultspawn.spawnpoint.transform.position;
        }
        current = deathtime;
    }
    void Update()
    {
        if (dying)
        {
            dark += rate * Time.fixedDeltaTime;
            black.color = new Vector4(0, 0, 0, dark);
            current -= Time.fixedDeltaTime;
            if (current <= 0)
            {
                Respawn();
                current = deathtime;
            }
        }

    }
    public void EndGame()
    {
        dying = true;
        
    }
    
    public void Respawn()
    {
        dying = false;
        player.transform.position = spawn;
        black.color = new Vector4(0, 0, 0, 0);
        dark = 0;
        le.DeActivate();
    }
    public void Leave()
    {
        SceneManager.LoadScene(0);
    }
    
}
