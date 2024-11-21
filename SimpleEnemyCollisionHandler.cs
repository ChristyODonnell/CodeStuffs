using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyCollisionHandler : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            {

                col.gameObject.SendMessage("TakeDamage", 5);
                //Destroy(gameObject);
                Debug.Log("Item collected");

        }
    }
}
}
