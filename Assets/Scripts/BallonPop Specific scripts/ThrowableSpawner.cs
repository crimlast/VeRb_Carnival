using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    int numberToSpawn;
    float spawnRate;
    Vector3 randomPosition;
    int x, y, z;
    int limit;
    // Start is called before the first frame update
    void Start()
    {
        numberToSpawn = 20;
        limit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (limit <= numberToSpawn)
        {
            for (int i = 0; i < numberToSpawn; i++)
            {
                x = Random.Range(-25, 25);
                y = Random.Range(0, 3);
                z = Random.Range(-3, 6);
                randomPosition = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z);
                Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
                limit++;
            }
        }
    }
}
