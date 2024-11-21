using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementRange : MonoBehaviour
{

    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    public float chaseDistance;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        { if (distance <= chaseDistance)

                nav.SetDestination(player.position);

        }
    }
}
