using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// Script developed by Brian Gardiner & Annett Gardiner
public class ScoreManager : MonoBehaviour
{
	public static int score;        // The player's score.
	Text text;                      // Reference to the Text component.
	//****************************************************************************************************
	void Awake ()
	{
		text = GetComponent <Text> ();
		score = 0;
	}
	//****************************************************************************************************
	//****************************************************************************************************
	void Update ()
	{
		text.text = "SCORE: " + score;
	}
	//****************************************************************************************************
}