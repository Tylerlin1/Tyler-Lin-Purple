using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialog();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "You found my " + collectibles[clue] + "! Hooray!";
            end = true;
        }
        else
        {
            dialog = "No, that's not my " + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

    public void searchDialog()
    {
        if (clue == 0)
        {
            dialog = "Hi! Can you help me find my film to watch my movie " + "?";
        }

        if (clue == 1)
        {
            dialog = "Hi! Can you help me find my balloons for a gift " + "?";
        }

        if (clue == 2)
        {
            dialog = "Hi! My friend is dying! Can you help me find my life saver to save my friend " + "?";
        }

        if (clue == 3)
        {
            dialog = "Hi! I want to practice shooting, can you help me find my bull's eye " + "?";
        }

        if (clue == 4)
        {
            dialog = "Hi! I suddenly feel like smoking, can you help me find my pipe " + "?";
        }

        if (clue == 5)
        {
            dialog = "Hi! Can you help me find my key to my house " + "?";
        }

        if (clue == 6)
        {
            dialog = "Hi! I'm very hunger and would like to eat. Can you help me find my fish " + "?";
        }

        if (clue == 7)
        {
            dialog = "Hi! I'm trying to make some money, can you help me find my bird house " + "?";
        }

        if (clue == 8)
        {
            dialog = "Hi! Can you help me find my airhorn to annoy people " + "?";
        }

        if (clue == 9)
        {
            dialog = "Hi! I'm trying to show-off and do magic but unfortunately, I lost my my hat. Can you help me find my magic hat " + "?";
        }
    }

}
