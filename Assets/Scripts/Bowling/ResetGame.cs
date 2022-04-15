using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    // Pin objects themselves
    private static List<GameObject> pinObjects;
    // Initial positions of each pin in the pinObjects list
    private static List<Vector3> pinPositions;
    // The bowling ball object itself
    private static GameObject ballObject;
    // Initial position of the bowling ball object
    private static Vector3 ballPosition;

    // The parent to attach newly created pins to
    public Transform pinParent;
    // The pin to instantiate
    public GameObject pinPrefab;
    // The bowling ball to instantiate
    public GameObject ballPrefab;

    private void Awake()
    {
        pinObjects = new List<GameObject>();
        pinPositions = new List<Vector3>();
    }

    // Add pin to be tracked when resetting scene
    public static void AddPin(GameObject pinToAdd)
    {
        pinObjects.Add(pinToAdd);
        pinPositions.Add(pinToAdd.transform.position);
    }

    public static void SetBall(GameObject ballToSet)
    {
        ballObject = ballToSet;
    }

    // Effectively reset the scene so that the user can bowl again
    public void ResetScene()
    {
        Debug.Log("Reset scene called");
        ResetPins();
        ResetBall();
    }

    // Reset pins to how they were initially placed at the beginning of the scene
    private void ResetPins()
    {
        // List to hold newly created pins
        List<GameObject> newPinList = new List<GameObject>();

        for (int i = 0; i < pinPositions.Count; i++)
        {
            // Destroy the current pin
            Destroy(pinObjects[i]);
            // Create a new pin with the correct starting position and rotation, and add it to the new list
            newPinList.Add(Instantiate(pinPrefab, pinPositions[i], Quaternion.Euler(0, 180, 0), pinParent));
        }

        // Update the current pinObjects list with the new pins
        //pinObjects = newPinList;
    }

    // Reset bowling ball to how it was initially placed at the beginning of the scene
    private void ResetBall()
    {
        // Destroy the current bowling ball
        Destroy(ballObject);
        // Create a new ball with the correct starting position, and update the current ball object
        ballObject = Instantiate(ballPrefab, ballPosition, Quaternion.identity);
    }
}
