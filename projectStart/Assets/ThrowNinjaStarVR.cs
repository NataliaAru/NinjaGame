using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ThrowNinjaStarVR : MonoBehaviour
{
    public GameObject starObject;
    public GameObject starSpawn;

    private bool holding = false;
    private GameObject star;
    private Vector3 throwStart;

    // Update is called once per frame
    void Update()
    {

        if(Player.instance.rightHand.grabPinchAction.state && !holding)
        {
            Player.instance.rightHand.TriggerHapticPulse(2000); // doesn't work yet
            holding = true;
            SpawnStar();
        } 
        else if (!Player.instance.rightHand.grabPinchAction.state && holding) 
        {
            Throw();
            Player.instance.rightHand.TriggerHapticPulse(2000); // doesn't work yet
            holding = false;
        }
    }

    void Throw()
    {
        star = null;
    }

    void SpawnStar()
    {
        star = Instantiate(starObject, starSpawn.transform.position, starSpawn.transform.rotation) as GameObject;

        Player.instance.rightHand.AttachObject(star, GrabTypes.Pinch);

        throwStart = Input.mousePosition;
    }
}
