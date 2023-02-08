using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

    
   
{

    public GameObject ParticleExplosion;
   // public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "axe")
        {
            FindObjectOfType<GameManeger>().Endgame();
            Debug.Log("Game over");

            ParticleExplosion.SetActive(true);
           // Destroy(player);
            
        }
    }
}
