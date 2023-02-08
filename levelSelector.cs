using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelSelector : MonoBehaviour
{
    int levelsUnlocked;
    public Button[] levelButtons;



    private void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked",1);
        for(int i=0; i<levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
        }
        for (int i = 0; i <levelsUnlocked; i++)
        {
            levelButtons[i].interactable = true;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }    










    /*public Button[] levelbuttons;


    private void Start()
    {
        foreach (Button b in levelbuttons)
        {
            b.interactable = false;
        }

        int reachedlevel = PlayerPrefs.GetInt("reachedlevel", 1);

        for (int i = 0; i < reachedlevel; i++)
        {
            levelbuttons[i].interactable = true;
        }
    }

   /* public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    } */

}

  
