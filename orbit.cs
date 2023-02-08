using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    /* [SerializeField] private Camera cam;
     [SerializeField] private Transform target;
     [SerializeField] private float distanceToTarget = 3f;

     private Vector3 previousPosition;



     void LateUpdate()
     {
         cam.transform.position = target.position;
         if (Input.GetMouseButtonDown(0))
         {
             previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
         }
          if (Input.GetMouseButton(0))
         {
             Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
             Vector3 direction = previousPosition - newPosition;

             float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
           //  float rotationAroundXAxis = direction.y *180; // camera moves vertically

            // cam.transform.position = target.position;

            // cam.transform.Rotate(transform.right, rotationAroundXAxis);
             cam.transform.Rotate(transform.up, rotationAroundYAxis, Space.World); // <— This is what makes it work!



             previousPosition = newPosition;
         }
          if(Input.GetMouseButtonUp(0))
         {
             Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
             Vector3 direction = previousPosition - newPosition;

             float rotationAroundYAxis = -direction.x *0;
             cam.transform.Rotate(transform.up, rotationAroundYAxis, Space.World);
         }
         cam.transform.Translate(new Vector3(0, 0, -distanceToTarget));
     }*/
    
    
   
}
