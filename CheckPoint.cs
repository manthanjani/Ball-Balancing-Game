using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    // public GameObject flag;
    Vector3 spawnPoint;
    Vector3 cameraPos = new Vector3(-1.837f, 104.81f, -84.45f);
   public  GameObject[] hearts;
    public GameObject gameOverPanel;
    int i = 4;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -28.77f)
        {
            gameObject.transform.position = spawnPoint;
            Camera.main.transform.position = cameraPos;
            
            i--;
            Destroy(hearts[i]);

        }
        if(i==0)
        {
           
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
   

   
    private void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject.CompareTag("checkpoint") || other.gameObject.CompareTag("axe"))
            {

            spawnPoint = other.gameObject.transform.position;
           
            Destroy(other.gameObject);
            

        } 
    }
    
}
