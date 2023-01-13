using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
            }
            else
            {
                print("Cheater!");
            }
        }
    }
    // Start is called before the first frame update

}
