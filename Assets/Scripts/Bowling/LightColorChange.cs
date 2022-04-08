using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorChange : MonoBehaviour
{
    private Light light;

    public Color colorFrom;
    public Color colorTo;
    public float speedMultiplier = 1f;

    private void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    private void Update()
    {
        light.color = Color.Lerp(colorFrom, colorTo, Mathf.PingPong(Time.time * speedMultiplier, 1));
    }
}
