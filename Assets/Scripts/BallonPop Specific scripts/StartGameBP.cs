using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameBP : MonoBehaviour
{
    private GameObject balloonSpawn;
    private GameObject movement;
    private GameObject sMenu;
    // Start is called before the first frame update
    public void Start()
    {
        balloonSpawn = GameObject.Find("Balloons");
        movement = GameObject.Find("Locomotion System");
        sMenu = GameObject.Find("Start Menu");
    }

    public void StartBP()
    {
        balloonSpawn.SetActive(true);
        movement.SetActive(true);
        Destroy(sMenu);
    }
}
