using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    private Vector3 startPosition;

    public GameObject ring;

    void Start()
    {
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Board")
        {
            spawnRing();
        }
        else if (col.gameObject.name == "Terrain")
        {
            spawnRing();
        }
        else
        {

        }
    }

    private void spawnRing()
    {
        //GameObject a = Instantiate(ring) as GameObject;
        transform.position = startPosition;
        //Instantiate(ring, startPosition, Quaternion.identity);
        //Destroy(gameObject);
    }

}
