using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public Rigidbody rb;
    public float leftRightForce = 5f;
   
    void FixedUpdate()
    {
        if (ispressed)
        {

            Vector3 movement = Camera.main.transform.right * leftRightForce * Time.deltaTime;

            rb.AddForce(movement, ForceMode.VelocityChange);


            //  rb.AddForce(leftRightForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            //   player.transform.Translate(new Vector3(leftRightForce * Time.deltaTime, 0, 0), Camera.main.transform);
        }
       /* if (rb.position.y < -27.77f)
        {
            FindObjectOfType<GameManeger>().Endgame();
        }*/
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

}

