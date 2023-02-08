using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private Vector3 desiredPos;
    private Vector2 touchPosition;
    private float swipeResistance = 200f;
    float smoothSpeed = 10f;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            touchPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (!IsPointerOverUIObject())
            {
                float swipeForce = touchPosition.x - Input.mousePosition.x;
                if (Mathf.Abs(swipeForce) > swipeResistance)
                {
                    if (swipeForce < 0)
                    {
                        SlideCamera(true);
                    }
                    else
                    {
                        SlideCamera(false);
                    }
                }
            }
        }

    }

    private void FixedUpdate()
    {

        desiredPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);
        transform.LookAt(player); 
    }
    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }
    public void SlideCamera(bool left)
    {
        if(left)
        {
            offset = Quaternion.Euler(0, 90, 0) * offset;
        }
        else
            offset = Quaternion.Euler(0, -90, 0) * offset;
    }
}
