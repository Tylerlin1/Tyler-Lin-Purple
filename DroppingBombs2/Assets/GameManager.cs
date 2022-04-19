using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private spawner spawner;
    public GameObject title;
    public GameObject text;
    public Vector2 screenBounds;
    public GameObject playerPrefab;
    private GameObject player;
    private bool gameStarted = false;
    private GameObject splash;
    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<spawner>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        player = playerPrefab;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawner.active = false;
        title.SetActive(true);
        text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.anyKeyDown)
            {
                ResetGame();
            }
        }
        else
        {
            if (!player)
            {
                OnPlayerKilled();
            }
        }
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
            text.SetActive(false);
        }

        var nextBomb = GameObject.FindGameObjectsWithTag("Bomb");

        foreach (GameObject bombObject in nextBomb)
        {
            if (bombObject.transform.position.y < (-screenBounds.y) - 12 || !gameStarted)
            {
                Destroy(bombObject);
            }
        }

        void ResetGame()
        {
            spawner.active = true;
            title.SetActive(false);
            player = Instantiate(playerPrefab, new Vector3(0, 0, 0), playerPrefab.transform.rotation);
            gameStarted = true;
        }

        void OnPlayerKilled()
        {
            spawner.active = false;
            gameStarted = false;

            splash.SetActive(true);
        }
    }
}
