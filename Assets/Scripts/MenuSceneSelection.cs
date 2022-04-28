using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneSelection : MonoBehaviour
{
    public void LoadRingTossScene()
    {
        SceneManager.LoadScene("Ring toss");
    }
    public void LoadShootingGalleryScene()
    {
        SceneManager.LoadScene("Shooting gallery");
    }
    public void LoadBalloonPopScene()
    {
        SceneManager.LoadScene("Balloon pop");
    }
    public void LoadWhackAMoleScene()
    {
        SceneManager.LoadScene("Whack a mole");
    }
    public void LoadBowlingScene()
    {
        SceneManager.LoadScene("Bowling");
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("TheMainScene");
    }
}
