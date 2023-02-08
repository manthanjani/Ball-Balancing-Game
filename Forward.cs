using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Forward : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public Rigidbody rb;
    Vector3 vec;
    Vector3 force;
    public float ForwardForce;
    public GameObject manager;
   
   //public Transform cam;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (ispressed)
        {
            Vector3 movement = Camera.main.transform.forward * ForwardForce * Time.deltaTime;
            movement.y = 0;
            rb.AddForce(movement, ForceMode.VelocityChange);





            /* vec = Camera.main.transform.TransformDirection(vec);
            vec.y = 0;
            vec.x = 0;
            force = vec.normalized * ForwardForce;
            rb.AddForce(force , ForceMode.VelocityChange);*/


            //  rb.AddForce(0, 0, ForwardForce*Time.deltaTime, ForceMode.VelocityChange);
            /*   Vector3 camF = cam.forward;
               camF.y = 0;
               camF = camF.normalized;
               rb.position += (camF * ForwardForce * Time.deltaTime);*/




            

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
