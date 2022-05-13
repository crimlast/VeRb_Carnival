using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{
    [SerializeField] private int bounty;
    private Rigidbody rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            RegisterHit();
            GameManager.UpdateScore(bounty);
            GameManager.RemoveTarget(this);
        }
    }
    public void RegisterHit()
    {
        Debug.Log("Target hit: worth " + bounty);
    }
}
