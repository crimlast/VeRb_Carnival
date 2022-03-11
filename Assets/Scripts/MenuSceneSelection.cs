using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneSelection : MonoBehaviour
{
    public void LoadTestScene()
    {
        SceneManager.LoadScene("TestScene - Copy 1");
    }
}
