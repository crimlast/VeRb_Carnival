using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverActivateObject : MonoBehaviour
{
    public GameObject pic;
    public void activateObject()
    {
        pic.SetActive(true);
    }
    public void deactivateObject()
    {
        pic.SetActive(false);
    }
}
