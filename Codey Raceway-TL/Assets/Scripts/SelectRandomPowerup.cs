using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> PowerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ItemBox")
        {
            randomNumberInList = Random.Range(0, PowerupList.Count);
            chosenPowerup = PowerupList[randomNumberInList];
        }
    }
}
