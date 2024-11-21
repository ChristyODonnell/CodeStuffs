using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{

    public int enemyScoreValue; // creates a public field for score value

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            ScoreManager.score = ScoreManager.score + enemyScoreValue;
            Destroy(gameObject);
            Debug.Log("Item collected");

        }
    }
}