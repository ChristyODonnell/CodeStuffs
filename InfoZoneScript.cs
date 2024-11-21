using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // make sure to add this line 
using UnityEngine;

public class InfoZoneScript : MonoBehaviour
{
    public GameObject uiInfo;
    public Text InfoText;
    public string EnterText = ""; //creates a public field for text input

    // Start is called before the first frame update
    void Start()
    {
        uiInfo.SetActive(false); //hides the InfoZonePanel on the Canvas
        Debug.Log("InfoZoneStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

          {
            uiInfo.SetActive(true); // makes the InfoZonePanel visible
            InfoText.text = EnterText; // displays the text you added in the public field
            Debug.Log("InfoZoneDisplayText");
          }

    }

    private void OnTriggerExit(Collider other) 
    {
    if (other.gameObject.tag == "Player")

        {
            uiInfo.SetActive(false); // see line 15
            Debug.Log("InfoZoneDisplayEmpty");
         }

    }

}
