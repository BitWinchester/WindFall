using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{



    public float wanderRadius;
    public float wanderTimer;

    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    private float timer;


    void OnEnable()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        timer = wanderTimer + Random.Range(timer, timer * 4f);
    }


    void Update()
    {
        Move();
    }

    public void Move()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        UnityEngine.AI.NavMeshHit navHit;

        UnityEngine.AI.NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }

    //Walking 

    // Needs in another script? 
    //Behavoirs in a second script as well ? 
    // 

}

