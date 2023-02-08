using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvlSelect : MonoBehaviour
{
  public  Button[] lvlButtons;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        for (int i = 0; i <lvlButtons.Length; i++)
        {
            if(i+2 > levelAt)
            {
                lvlButtons[i].interactable = false;
            }
        }
       
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        Time.timeScale = 1f;
    }



}
