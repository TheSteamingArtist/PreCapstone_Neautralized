using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform[] points;

    private int destPoint = 0;

    private NavMeshAgent agent;

    public bool[] lineOfSight = new bool[3];

    public float shootCoolDown = .5f;

    public float patrolCoolDown = 5f;

    public GameObject target;

    public GameObject lineOfSightTarget;

    public GameObject bulletPrefab;

    private float chaseSpeed = 5;

    public bool inTrigger;

    public float meter = 0;

    private float meterSpeed = 30f;

    public Transform player;

    public State state;

    float distance;

    private bool alive;

    public enum State
    {
        PATROL,
        CHASE,
        INVESTIGATE
    }


    /// Investigation
    private Vector3 investigatePlayer;
    private float timer = 0;

    private float investigateWait = 10f;

    /// Sight

    public float heightMul;

    public float sightDis = 30f;

    void Start()
    { 

        player = GameObject.FindGameObjectWithTag("Player").transform;

        lineOfSightTarget = GameObject.FindGameObjectWithTag("Target");

        heightMul = 1.0f;

        alive = true;

        agent = this.gameObject.GetComponent<NavMeshAgent>();

        state = EnemyAI.State.PATROL;

        StartCoroutine("Enemy");
        //GoOnNextPoint();
    }

    void Update()
    {
        bool noLineOfSight = true;

        foreach(bool los in lineOfSight)
        {
            if(los == true)
            {
                gameObject.GetComponent<Light>().color = Color.red;
                meter += Time.deltaTime * meterSpeed;
                noLineOfSight = false;
                break;
                
            }
            else
            {
                gameObject.GetComponent<Light>().color = Color.white;
                meter = Mathf.Max(0, meter -= Time.deltaTime * meterSpeed + 1);
            }

            if (los == true && state == EnemyAI.State.CHASE)
                gameObject.GetComponent<Light>().color = Color.red;

            else if(los == false && state == EnemyAI.State.CHASE)
            {
                gameObject.GetComponent<Light>().color = Color.yellow;
            }


        }

        //create logic to decrement the meter and have a range between two variables to check whether or not its within a range and set it back to patrolling


        //if (state == EnemyAI.State.PATROL)
        //    gameObject.GetComponent<Light>().color = Color.white;

        if (meter >= 100)
            state = EnemyAI.State.CHASE;
        

        if (noLineOfSight && state != EnemyAI.State.CHASE && !inTrigger)
        {
            meter -= Time.deltaTime * meterSpeed;
        }

       if(noLineOfSight && state == EnemyAI.State.INVESTIGATE)
        {
            if(patrolCoolDown > 0)
            {
                patrolCoolDown -= Time.deltaTime;
            }
            else
            {
                if(meter <= 0)
                {
                    state = EnemyAI.State.PATROL;
                }
                patrolCoolDown = 5;
            }


        }


       //Empty gameobject draw raycast from empty gameobject in update function have raycast go back in forth between two angles for the alert function and investigate

        

        meter = Mathf.Clamp(meter, 0, 100);


        
        if (!agent.pathPending && agent.remainingDistance < 0.5f && state == EnemyAI.State.PATROL)
            GoOnNextPoint();


        distance = Vector3.Distance(player.position, transform.position);


    }


    void EnemyPatrol()
    {
            GoOnNextPoint();
    }

    void GoOnNextPoint()
    {
        if(Vector3.Distance(this.transform.position, points[destPoint].transform.position) >= 5)
        {
            agent.SetDestination(points[destPoint].transform.position);
        }
        else if(Vector3.Distance(this.transform.position, points[destPoint].transform.position) <= 5)
        {
            destPoint = Random.Range(0, points.Length);
        }
        
    }


    void ChasePlayer()
    {
        lineOfSight[0] = false;
        lineOfSight[1] = false;
        lineOfSight[2] = false;


        agent.SetDestination(lineOfSightTarget.transform.position + (transform.position - lineOfSightTarget.transform.position).normalized * 2);

        agent.speed = chaseSpeed;
        
        RaycastHit hit;

        if(Physics.Raycast(transform.position, player.transform.position - transform.position,out hit))
        {
            if(hit.collider.gameObject == player.gameObject)
            {
                Debug.Log("Detected");

                lineOfSightTarget.transform.position = player.transform.position;

                

                if (shootCoolDown > 0)
                    shootCoolDown -= Time.deltaTime;
                else
                {
                    shootCoolDown = .5f;

                    Debug.Log("Shoot");

                    var bullet = Instantiate(bulletPrefab, transform.position + transform.forward * 2, transform.rotation);

                    bullet.GetComponent<Rigidbody>().velocity = transform.forward * 10;

                    Destroy(bullet, 1);



                }
            }
            else
            {
                Debug.Log("Undetected");
                if(Vector3.Distance(transform.position,lineOfSightTarget.transform.position) <= 3)
                {
                    Debug.Log("Patrol");
                    state = EnemyAI.State.PATROL;
                    meter = 0;
                }
            }
        }



    }

    IEnumerator Enemy()
    {
        while (alive)
            {
                switch (state)
                    {
                        case State.PATROL:

                        EnemyPatrol();

                        break;

                        case State.CHASE:

                        ChasePlayer();

                        break;

                        case State.INVESTIGATE:

                        InvestigatePlayer();

                        break;
                    }
            yield return null;
            }


        }

        void InvestigatePlayer()
    {
        timer += Time.deltaTime;

        RaycastHit hit;

        Debug.DrawRay(transform.position + Vector3.up * heightMul, transform.forward * sightDis, Color.green);
        Debug.DrawRay(transform.position + Vector3.up * heightMul, (transform.forward + transform.right).normalized * sightDis, Color.green);
        Debug.DrawRay(transform.position + Vector3.up * heightMul, (transform.forward - transform.right).normalized * sightDis, Color.green);

        agent.SetDestination(transform.position);


        if(Physics.Raycast(transform.position + Vector3.up * heightMul, transform.forward, out hit, sightDis))
        {
            if(hit.collider.gameObject.tag == "Player")
            {

                lineOfSight[0] = true;

                target = player.gameObject;

                
                
            }
            else
            {
                lineOfSight[0] = false;
            }
        }

        if (Physics.Raycast(transform.position + Vector3.up * heightMul, (transform.forward + transform.right).normalized, out hit, sightDis))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                lineOfSight[1] = true;

                target = player.gameObject;
            }
            else
            {
                lineOfSight[1] = false;
            }    
        }

        if (Physics.Raycast(transform.position + Vector3.up * heightMul, (transform.forward - transform.right).normalized, out hit, sightDis))
        {
            if (hit.collider.gameObject.tag == "Player")
            {

                lineOfSight[2] = true;

                target = player.gameObject;

            }
            else
            {
                lineOfSight[2] = false;
            }
        }


        //agent.SetDestination(this.transform.position);
        

        if(timer >= investigateWait)
        {
            //state = EnemyAI.State.PATROL;

            timer = 0;
        }


        

    }

    void OnTriggerEnter(Collider other)
    {

        

        if (other.tag == "Player")
        {
            //if (state == EnemyAI.State.INVESTIGATE || state == EnemyAI.State.CHASE)
            //{
            //    gameObject.GetComponent<Light>().color = Color.red;
            //}

            inTrigger = true;

            state = EnemyAI.State.INVESTIGATE;

            //StartCoroutine("WaitforState");
            //state = EnemyAI.State.CHASE;

            investigatePlayer = other.gameObject.transform.position;
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            transform.LookAt(player.transform.position);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;

           

        }
            


        
    }

    //IEnumerator WaitforState()
    //{
    //    yield return new WaitForSeconds(2f);

    //    if (distance >= 10f)
    //        state = EnemyAI.State.PATROL;
    //    else if (distance <= 10)
    //        state = EnemyAI.State.CHASE;

    //    StopCoroutine("WaitforState");
    //}

    void StartChase()
    {
        state = EnemyAI.State.CHASE;
    }

    void StartPatrol()
    {
        state = EnemyAI.State.PATROL;
    }
}