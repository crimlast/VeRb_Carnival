using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameBP : MonoBehaviour
{
    public GameObject spawn;
    public GameObject movement;
    public GameObject sMenu;

    // Start is called before the first frame update
    public void Start()
    {
    //    balloonSpawn = GameObject.Find("Balloons");
    //    movement = GameObject.Find("Locomotion System");
    //    sMenu = GameObject.Find("Start Menu");
    }

    void StartBP()
    {
        spawn.SetActive(true);
        movement.SetActive(true);
        Destroy(sMenu);
    }
}
