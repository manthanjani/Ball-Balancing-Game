using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class someStartForce : MonoBehaviour
{
   public Rigidbody rb;
    void Start()
    {
      //  rb.AddForce(0, 0, -5f * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, -7f * Time.deltaTime);
    }
}
