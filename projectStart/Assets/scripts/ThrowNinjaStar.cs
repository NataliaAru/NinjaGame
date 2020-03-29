using UnityEngine;

public class ThrowNinjaStar : MonoBehaviour
{
    public float xForce, yForce, zForce;

    public GameObject starObject;
    public GameObject starSpawn;

    private bool thrown = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !thrown)
        {
            Throw();
            thrown = true;
            
        } else
        {
            thrown = false;
        }
    }

    void Throw()
    { 
        GameObject star = Instantiate(starObject, starSpawn.transform.position, starSpawn.transform.rotation) as GameObject;
        Rigidbody rb = star.GetComponent<Rigidbody>();
        rb.AddForce(xForce, yForce, zForce);
        rb.angularVelocity = new Vector3(1000, 1000, 1000);
        rb.useGravity = true;
    }
}
