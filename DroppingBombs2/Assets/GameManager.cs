using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private spawner spawner;
    public GameObject title;
    public GameObject text;
    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<spawner>();
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
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
            text.SetActive(false);
        }
    }
}
