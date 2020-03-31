using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject shatteredversion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("sphere"))
            ShatterObject();
    }

    void ShatterObject()
    {
        Instantiate(shatteredversion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
