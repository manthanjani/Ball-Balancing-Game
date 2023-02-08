using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManeger : MonoBehaviour
{
    
    bool gameEnded = false;
    public GameObject CompleteLevelUI;
    public GameObject PauseButton,hearts;

    //public string[] nextLevel;
   // public int[] levelToUnlock;

   
   

    //public GameObject ParticleExplosion;
    public void GameEnded()
    {
       CompleteLevelUI.SetActive(true);
        PauseButton.SetActive(false);
        hearts.SetActive(false);
    }
     
    public void Endgame()
    {
       if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart",0f);
        }
    }

    void Restart()
    {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
     //   ParticleExplosion.SetActive(false);
        
    }

   
}
