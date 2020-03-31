using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStar : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        //rb.useGravity = false;
        //rb.freezeRotation = true;
        rb.velocity = new Vector3(0,0,0);
    }
}
