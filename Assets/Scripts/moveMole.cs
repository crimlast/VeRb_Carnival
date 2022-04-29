using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMole : MonoBehaviour
{

    float speed = 1f;

    void Start()
    {
        StartCoroutine("Reset");
    }

    void Update()
    {
        var sledge = GameObject.Find("hammer");
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
       // transform.position = Vector3.MoveTowards(transform.position, new Vector3(pos.x, 1f, pos.z), speed * Time.deltaTime);

        int up = Random.Range(1, 5);
        yield return new WaitForSeconds(up);

        transform.position = new Vector3(pos.x, -2, pos.z);
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(pos.x, -200f, pos.z), speed * Time.deltaTime);
        //Put code after waiting here
        int down = Random.Range(1, 10);
        yield return new WaitForSeconds(down);
        //You can put more yield return new WaitForSeconds(1); in one coroutine

        StartCoroutine("Reset");
    }
}