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
    public void LoadShootingGallaryScene()
    {
        SceneManager.LoadScene("Shooting gallary");
    }
    public void LoadBalloonPopScene()
    {
        SceneManager.LoadScene("Balloon pop");
    }
    public void LoadWhackAMoleScene()
    {
        SceneManager.LoadScene("Whack a mole");
    }
    public void LoadRandomScene()
    {
        SceneManager.LoadScene("Random");
    }
}
