using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] SpawnPoints;
    [SerializeField] private TextMesh scoreboard;
    [SerializeField] private TextMesh moleboard;
    private static Spawner CurrentActiveSpawn;
    public static int score;
    private void Start()
    {
        NewSpawn();
        UpdateScore(0);
    }
    private void Update()
    {
        bool newSpawn = true;
        foreach(GameObject i in SpawnPoints)
        {
            if(i.GetComponent<Spawner>().active == true)
            {
                newSpawn = false;
            }
        }
        if (newSpawn)
            NewSpawn();

        scoreboard.text = "Score : " + score;
    }
    public void NewSpawn()
    {
        if(CurrentActiveSpawn != null)
            CurrentActiveSpawn.Despawn();
        CurrentActiveSpawn = SpawnPoints[Random.Range(0, SpawnPoints.Length)].GetComponent<Spawner>();
        CurrentActiveSpawn.Init();
    }
    public static void RemoveTarget(Target target)
    {
        CurrentActiveSpawn.Despawn();
    }
    public static void UpdateScore(int value)
    {
        score += value;
    }
    public static int GetScore()
    {
        return score;
    }
}
