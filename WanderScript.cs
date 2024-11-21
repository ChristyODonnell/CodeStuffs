using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderScript : MonoBehaviour
{
    private bool canWander = true;
    private float wanderRadius = 30f;
    Transform targetTransform;
    Transform player;
    NavMeshAgent nav;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WanderAround();
    }

    public void SetNavDestination(Transform destination)
    {
        
        
            nav.SetDestination(destination.position);
            transform.LookAt(targetTransform);
            nav.speed = 3.5f;
        
    }

    void WanderAround()
    {       
        if (targetTransform == null && canWander == true)
        {
            nav.speed = 2f;
            Vector3 _newPos = RanNavSphere(player.transform.position, wanderRadius, -1);
            nav.SetDestination(_newPos);
            canWander = false;
            float _ranNum = Random.Range(0, 10);
            StartCoroutine(WanderDelay(_ranNum));
        }
    }

    Vector3 RanNavSphere(Vector3 _origin, float _dist, int _layerMask)
    {
        Vector3 _ranDirection = Random.insideUnitSphere * _dist;
        _ranDirection += _origin;
        NavMeshHit _navHit;
        NavMesh.SamplePosition(_ranDirection, out _navHit, _dist, _layerMask);
        return _navHit.position;
    }

    IEnumerator WanderDelay(float _ranNum)
    {
        yield return new WaitForSeconds(_ranNum);
        canWander = true;
    }
}
