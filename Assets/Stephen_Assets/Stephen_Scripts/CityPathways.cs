using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class CityPathways : MonoBehaviour
{

    public Transform[] points;

    private int destPoint = 0;

    public State state;

    private NavMeshAgent agent;

    private bool alive;

    public enum State
    {
        PATROL,

    }


    void Start()
    {
        
        agent = this.gameObject.GetComponent<NavMeshAgent>();

        state = CityPathways.State.PATROL;


        alive = true;

        


    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f && state == CityPathways.State.PATROL)
            GoOnNextPoint();

        StartCoroutine("Enemy");
    }


    void GoOnNextPoint()
    {
        if (Vector3.Distance(this.transform.position, points[destPoint].transform.position) >= 5)
        {
            agent.SetDestination(points[destPoint].transform.position);
        }
        else if (Vector3.Distance(this.transform.position, points[destPoint].transform.position) <= 5)
        {
            destPoint = Random.Range(0, points.Length);
        }

    }


    IEnumerator Enemy()
    {
        while (alive)
        {
            switch (state)
            {
                case State.PATROL:

                    GoOnNextPoint();
                    break;
            }
            yield return null;
        }


    }
}
