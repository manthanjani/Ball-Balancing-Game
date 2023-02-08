using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCredits : MonoBehaviour
{
   public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
   public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
