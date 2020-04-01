using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject shatteredversion;
    public HashSet<string> destroyers;
    // Start is called before the first frame update
    void Start()
    {
        destroyers = new HashSet<string>();
        destroyers.Add("sphere");
        destroyers.Add("ninjaStar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (destroyers.Contains(collision.gameObject.tag))
            ShatterObject();
    }

    void ShatterObject()
    {
        Instantiate(shatteredversion, transform.position, transform.rotation); // if you scale the original object, the shattered object
                                                                               // the shattered object does not scale with it - Marc
        Destroy(gameObject);
    }
}
