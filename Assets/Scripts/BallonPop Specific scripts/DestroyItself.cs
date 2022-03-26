using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItself : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        //Destroy itself after 3 seconds
        Destroy(this, 3);
    }
}
