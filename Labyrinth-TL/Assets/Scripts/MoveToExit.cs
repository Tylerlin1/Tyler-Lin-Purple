using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToExit : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    public Transform exit;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = exit.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (agent.hasPath)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
