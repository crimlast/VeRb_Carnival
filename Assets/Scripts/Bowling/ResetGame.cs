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

    private BowlingScore scoreScript;

    // The parent to attach newly created pins to
    public Transform pinParent;
    // The pin to instantiate
    public GameObject pinPrefab;
    // The bowling ball to instantiate
    public GameObject ballPrefab;
    // Particle systems
    public ParticleSystem pinParticles;
    // public ParticleSystem ballParticles;

    private void Awake()
    {
        pinObjects = new List<GameObject>();
        pinPositions = new List<Vector3>();
    }

    private void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<BowlingScore>();
    }

    // Add pin to be tracked when resetting scene
    public static void AddPin(GameObject pinToAdd)
    {
        pinObjects.Add(pinToAdd);
        pinPositions.Add(pinToAdd.transform.position);
    }

    public static void SetBall(GameObject ballToSet, Vector3 ballPos)
    {
        ballObject = ballToSet;
        ballPosition = ballPos;
    }

    // Effectively reset the scene so that the user can bowl again
    public void ResetScene()
    {
        scoreScript.ResetScore();
        ResetPins();
        ResetBall();

        // Particle effects
        pinParticles.Stop();
        pinParticles.Play();
    }

    // Reset pins to how they were initially placed at the beginning of the scene
    private void ResetPins()
    {
        Pin.ResetPinInfo();

        GameObject[] pinObjectsToDelete = new GameObject[pinObjects.Count];
        Vector3[] pinPositionsToDelete = new Vector3[pinPositions.Count];

        pinObjects.CopyTo(pinObjectsToDelete);
        pinPositions.CopyTo(pinPositionsToDelete);

        pinObjects.Clear();
        pinPositions.Clear();

        for (int i = 0; i < pinPositionsToDelete.Length; i++)
        {
            // Destroy the current pin
            Destroy(pinObjectsToDelete[i]);
            // Create a new pin with the correct starting position and rotation, and add it to the new list
            Instantiate(pinPrefab, pinPositionsToDelete[i], Quaternion.Euler(0, 180, 0), pinParent);
        }
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
