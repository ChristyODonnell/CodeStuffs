using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("/Started");
    }

    public void LoadScene(string SceneName)
    {
        Debug.Log("loading: " + SceneName);
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }

    void Update()
    {
        if (Input.GetKeyDown("m"))
        {

            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);

        }
    }
}
