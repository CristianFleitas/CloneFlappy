using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenaryManager : MonoBehaviour
{
    [SerializeField]private GameObject ground;
    private float SpawnCooldown;
    private int SpawnCounter;
    public GameObject[] obstacules;
    void Start()
    {
        SpawnCounter = 0;
        SpawnCooldown = 0;
        InstantiateNextGround();
    }

    void Update()
    {
        if(SpawnCounter == 4)
        {
            InstantiateNextGround();
            SpawnCounter = 0;
        }
        SpawnCooldown += Time.deltaTime;
        
    }
    private void InstantiateNextGround()
    {

    }
}
