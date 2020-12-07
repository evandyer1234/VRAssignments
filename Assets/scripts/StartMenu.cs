using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{ 
    public GameObject floor;
    public GameObject sightlight;
    public GameObject main;
    public GameObject credits;

    public Player player;

    public AudioSource source;

    float playerspeed;
    public float waittime = 1f;
    
    
    void Start()
    {
        playerspeed = player.speed;
        player.speed = 0;
        sightlight.SetActive(false);
    }

   public void StartGame()
   {
        player.speed = playerspeed;   
        floor.SetActive(false);
        sightlight.SetActive(true);
        source.Play();
   }
    public void ToCredits()
    {
        main.SetActive(false);
        credits.SetActive(true);
    }

    public void Back()
    {
        main.SetActive(true);
        credits.SetActive(false);
    }
    
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Debug.Log("Quit");
        Application.Quit();
    }
}
