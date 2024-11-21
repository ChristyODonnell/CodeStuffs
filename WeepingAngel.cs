using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WeepingAngel : MonoBehaviour
{
    bool isvisible = false;
    private float wanderRadius = 30f;
    private float Timer;
    Transform targetTransform;
    public Transform player;
    NavMeshAgent nav;
    Vector3 _newPos;
    public AudioSource scratch;

    void Awake()
    {       
        nav = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        scratch.enabled = false;
        Timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log((player.position - transform.position).magnitude);
        UnFreeze();
        if (!isvisible)                                                                                                      //Checks if player is looking
        {
            if ((player.position - transform.position).magnitude<3)
            {
                player.SendMessage("Die");
                Debug.Log("in");
            }
        }

    }

    void Hunt()                                                                                                                             //Method for hunting the player
    {      
        _newPos = player.position;                                                                                                      //Goes to the player                               
        nav.SetDestination(_newPos);
    }

    void Wander()
    {
        if (Timer > 0)
        {
            Timer = Timer - Time.deltaTime;
        }
        else
        {
            Timer = Random.Range(5, 10);

            if (targetTransform == null)
            {
                float distance = 30f;
                Vector3 _ranDirection = Random.insideUnitSphere * distance;
                _ranDirection += player.transform.position;
                NavMeshHit _navHit;
                NavMesh.SamplePosition(_ranDirection, out _navHit, wanderRadius, -1);
                Vector3 _newPos = _navHit.position;
                nav.SetDestination(_newPos);
            }
        }

    }

    bool LineOfSight()
    {
        RaycastHit Hit;
        Vector3 Direction;
        Direction = player.position - transform.position;
        Vector3 Start = transform.position;
        Start.y += 0.5f;
        if (Physics.Raycast(Start, Direction, out Hit))                                                                         //Checks if the ray hits a collider
        {
            Debug.Log("Ray hit-->" + Hit.transform.gameObject.name + " at " + Hit.distance.ToString());
            if (Hit.collider.tag == "Player")                                                                                                     //Checks if that collider is a player
            {
                return true;
            }

        }

        return false;

    }

    void UnFreeze()                                                                                                                         //Method Checking if movement is allowed
    {
        if (isvisible && LineOfSight())                                                                                                      //Checks if player is looking
        {
            scratch.enabled = false;
            nav.SetDestination(transform.position);
        }

        else
        {
            scratch.enabled = true;
            if (LineOfSight())
            {
                Hunt();
            }

            else
            {
                Wander();
            }

        }      
    }

    private void OnBecameVisible()
    {
        isvisible = true;
    }

    private void OnBecameInvisible()
    {
        isvisible = false;       
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            {
                col.gameObject.SendMessage("Die");
                Debug.Log("in");
            }
        }
    }
}
