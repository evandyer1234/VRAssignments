using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public Vector3 spawn;
    public checkpoint defaultspawn;
    public Renderer black;
    bool dying = false;
    float dark = 0;
    public float rate = 10f;
    public GameObject player;

    private void Start()
    {
        spawn = defaultspawn.spawnpoint.transform.position;
    }
    void Update()
    {
        if (dying)
        {
            dark += rate * Time.fixedDeltaTime;
            if (dark <= 255f)
            {
                Respawn();
            }
            else
            {
                black.material.color = new Vector4(0, 0, 0, dark);
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
        black.material.color = new Vector4(0, 0, 0, 255f);
        dark = 0;

    }
    public void Leave()
    {
        SceneManager.LoadScene(0);
    }
}
