using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //this script will have all information stored about the game and game state
    private static GameManager instance; //Singelton pattern
    private string _currentLevel = string.Empty;
    private readonly string[] LEVELS = { "ninjaStars", "breakObjects", "fightMonsters", "final" };
    private int attackWave = -1; //which attackWave is currently active
    public static GameManager GetInstance()
    {
        return instance;
    }

    public int GetAttackWave()
    {
        return attackWave;
    }
    void Awake()
    {
        if(instance == null)
        {
            
            instance = this;
            Debug.Log("Instance is created");
        }
        else
        {
            Debug.LogError("there are multiple game managers");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _currentLevel = LEVELS[0];
        Debug.Log(_currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
