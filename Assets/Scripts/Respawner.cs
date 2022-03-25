using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public GameObject ring;
    
    void start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Board")
        {
            spawnRing();
        }
        else if(col.gameObject.name == "Terrain")
        {
            spawnRing();
        }
        else 
        {
            
        }
    }

    private void spawnRing()
    {
        GameObject a = Instantiate(ring) as GameObject;
        a.transform.position = new Vector3(4.65f, 0.7f, -1.228f);
    }

}
