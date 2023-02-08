using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenefunctions : MonoBehaviour
{
   
    public void LoadNextScene()
    {

        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if(currentLevel >= PlayerPrefs.GetInt("levelsUnlocked", 1))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel );
        }
        
        
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      /*  int nexlevel = SceneManager.GetActiveScene().buildIndex + 1;

        if (nexlevel == 7)
        {
            SceneManager.LoadScene(0);
        }
        if (PlayerPrefs.GetInt("reachedlevel",1)<nexlevel) 
        {
            PlayerPrefs.SetInt("reachedlevel", nexlevel); }
        SceneManager.LoadScene(nexlevel);*/
    }

    
}
