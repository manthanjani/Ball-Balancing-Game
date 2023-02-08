using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletePrefs : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
            
        }
    }
}
