using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{

    public float seconds = 5;
    public GameObject ItemBox;

    public int numberOfBoxes;

    public int modifyXPosition;
    public int modifyZPosition;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject ItemBoxClone = Instantiate(ItemBox,
                new Vector3(
                    transform.position.x + modifyXPosition*i,
                    transform.position.y,
                    transform.position.z + modifyZPosition*i
                    ),
                transform.rotation);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
             gameObject.SetActive(false);
        }
        Invoke("ItemBoxRespawn", 5f);
    }

    private void ItemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
