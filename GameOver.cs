using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public void OnRestart()
    {

        FindObjectOfType<GameManeger>().Endgame();
        Time.timeScale = 1;

    }

    public void LevelSelectMenu()
    {
       
        SceneManager.LoadScene(1);

        Time.timeScale = 1f;

    }
}
