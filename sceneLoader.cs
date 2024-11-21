using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
// Brian Gardiner / Annett Vock DBFS.

//***************************************************
public class sceneLoader : MonoBehaviour {


	void Start () 
	{
		Debug.Log ("/Started");
	}


	//***************************************************
	public void LoadScene(string SceneName)
	{
		Debug.Log ("loading: "+ SceneName);
		//Application.LoadLevel (SceneName);//Old way of doing it, new way below. 
		SceneManager.LoadScene(SceneName,  LoadSceneMode.Single);
	}
	//***************************************************
}
