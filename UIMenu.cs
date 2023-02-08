using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{

    public GameObject PauseUIPanel;

    public void PauseGame()
    {
        PauseUIPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OnResume()
    {
        PauseUIPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}
