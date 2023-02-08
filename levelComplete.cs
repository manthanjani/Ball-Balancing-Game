using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
   public GameManeger gameManeger;
    public int nextSceneLoad;
    private void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 22 )
        {
            Debug.Log("You Win");
        } 
        else
        {
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {

                PlayerPrefs.SetInt("levelAt", nextSceneLoad);}
                }
                gameManeger.GameEnded();}
    }
