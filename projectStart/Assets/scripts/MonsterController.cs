using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public float speed = 4;
    public int wave = 1;
    NavMeshAgent agent;
    GameObject player;
    GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        manager = GameManager.GetInstance();
        if(agent == null || manager == null)
        {
            Debug.Log("something is wrong");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.GetAttackWave() == wave)
        {
            //follow the Player!!
        }
        
    }
}
