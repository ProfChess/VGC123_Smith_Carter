using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int StartingLives;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.lives = StartingLives;
        GameManager.Instance.currentLevel = this;
        GameManager.Instance.SpawnPlayer(spawnPoint);
    }

   


    // Update is called once per frame
    void Update()
    {
        
    }
}
