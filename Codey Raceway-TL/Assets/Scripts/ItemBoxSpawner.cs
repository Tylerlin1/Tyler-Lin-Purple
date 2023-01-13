using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{

    public GameObject ItemBox;

    public int numberOfBoxes;

    public int modifyXPosition;
    public int modifyZPosition;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hi");
        for (int i = 0; i < numberOfBoxes; i++)
        {
            Debug.Log(transform.position);
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
    void Update()
    {
        
    }
}
