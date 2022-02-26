using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    //Platform gameobject
    [Header("Platform Object")]
    public GameObject platform;
    //Default position for the platform 
    float pos = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Integer i equals 1000
        for (int i = 0; i < 1000; i++)
        {
            //Execute SpawnPlatforms
            SpawnPlatforms();
        }
    }

    void SpawnPlatforms()
    {
        //Spawn platforms randomly on the x axis and place them on the Y axis every 2.5
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Game Over Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    //Game over function
    public void GameOver()
    {
        //Game Over Canvas is active
        gameOverCanvas.SetActive(true);
    }
}
