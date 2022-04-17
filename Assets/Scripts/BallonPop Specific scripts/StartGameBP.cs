using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameBP : MonoBehaviour
{
    public GameObject spawn;
    public GameObject movement;
    public GameObject sMenu;
    public GameObject playerCanvas;


    // Start is called before the first frame update
    public void Start()
    {
    //    timer.Find("EventHandler");
    //    balloonSpawn = GameObject.Find("Balloons");
    //    movement = GameObject.Find("Locomotion System");
    //    sMenu = GameObject.Find("Start Menu");
    }

    void StartBP()
    {
        spawn.SetActive(true);
        movement.SetActive(true);
        playerCanvas.SetActive(true);
        Destroy(sMenu);
    }
}
