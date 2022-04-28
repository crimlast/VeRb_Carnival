using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMole : MonoBehaviour
{

    

    void Start()
    {
        StartCoroutine("Reset");
    }

    void Update()
    {
        var sledge = GameObject.Find("sledgeHammer");
        float distance = Vector3.Distance(transform.position, sledge.transform.position);  //object is the object you want to check for hit
        if (distance < .05f)
        {  //some small number
            Destroy(gameObject);
        }
    }



    IEnumerator Reset()
    {
        var pos = transform.position;
        //var newY = startY + height * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(pos.x, -.2f, pos.z);

        int up = Random.Range(2, 10);
        yield return new WaitForSeconds(up);

        transform.position = new Vector3(pos.x, -2, pos.z);
        //Put code after waiting here
        int down = Random.Range(10, 20);
        yield return new WaitForSeconds(down);
        //You can put more yield return new WaitForSeconds(1); in one coroutine

        StartCoroutine("Reset");
    }
}