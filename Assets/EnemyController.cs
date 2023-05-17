using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform targetPlayer;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Vector3.Distance(targetPlayer.position, transform.position) < 100000000000000)
        {
            agent.SetDestination (targetPlayer.position);
        }
    }
    
}
