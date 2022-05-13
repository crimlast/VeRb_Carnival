using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private GameObject model;
    public bool active;
    void Awake()
    {
        active = false;
    }
    public void Init()
    {
        Vector3 pos = gameObject.GetComponent<Transform>().position;
        model = Instantiate(prefab, pos, Quaternion.identity);
        active = true;
    }

    public virtual void Despawn()
    {
        Destroy(model);
        active = false;
    }
}
