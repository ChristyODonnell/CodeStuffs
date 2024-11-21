using UnityEngine;
using System.Collections;
// Brian Gardiner / Annett Vock DBFS.
//***************************************************
public class soundPlayer : MonoBehaviour {
	AudioSource theSound;

	void Start () 
	{
		theSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	//***************************************************
	public void PlaySound()
	{
		theSound.Play();
	}
	//***************************************************
}
