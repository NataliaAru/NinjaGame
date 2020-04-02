using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class EquipSword : MonoBehaviour
{
    public GameObject swordObject;
    public GameObject swordSpawn;
    public Hand hand;

    private GameObject sword;

    // Update is called once per frame
    void Update()
    {
        if (hand.GetGrabStarting() == GrabTypes.Pinch)
        {
            hand.TriggerHapticPulse(2000); // doesn't work yet
            SpawnSword();
        }
        else if (hand.GetGrabEnding() == GrabTypes.Pinch)
        {
            DestroySword();
            hand.TriggerHapticPulse(2000); // doesn't work yet
        }
    }

    void DestroySword()
    {
        Destroy(sword);
        sword = null;
    }

    void SpawnSword()
    {
        sword = Instantiate(swordObject, swordSpawn.GetComponent<Transform>()) as GameObject;

        hand.AttachObject(sword, GrabTypes.Pinch);
    }
}

