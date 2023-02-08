using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Back : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public Rigidbody rb;
    public float ForwardForce = 5f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (ispressed)
        {

            Vector3 movement = Camera.main.transform.forward * -ForwardForce * Time.deltaTime;
            movement.y = 0;

            rb.AddForce(movement, ForceMode.VelocityChange);


            // rb.AddForce(0, 0, -ForwardForce * Time.deltaTime, ForceMode.VelocityChange);
            // player.transform.Translate(new Vector3(0, 0, -ForwardForce * Time.deltaTime), Camera.main.transform);
        }
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
