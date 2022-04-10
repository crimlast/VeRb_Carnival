using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    private static List<GameObject> pinObjects;
    private static List<Vector3> pinPositions;

    public Transform pinParent;
    public GameObject pinPrefab;

    private void Awake()
    {
        pinObjects = new List<GameObject>();
        pinPositions = new List<Vector3>();
    }

    public static void AddPin(GameObject pinToAdd)
    {
        pinObjects.Add(pinToAdd);
        pinPositions.Add(pinToAdd.transform.position);
    }

    public void ResetScene()
    {
        for(int i = 0; i < pinPositions.Count; i++)
        {
            Destroy(pinObjects[i]);
            Instantiate(pinPrefab, pinPositions[i], Quaternion.Euler(0, 180, 0), pinParent);
        }
    }
}
