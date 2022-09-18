using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem trail;
    public ParticleSystem explosion;
    public GameObject player;

    void Start()
    {
        explosion.Stop();
        trail.Play();
    }


    void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
        trail.transform.position = player.transform.position;
    }
    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2);
        explosion.Play();
        trail.Stop();
    }

    void Reload()
    {
        SceneManager.LoadScene(1);
    }
}


