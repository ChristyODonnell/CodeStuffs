﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// Script developed by Brian Gardiner & Annett Gardiner
//****************************************************************************************************
public class PlayerHealth : MonoBehaviour
{
	public int startingHealth = 100;                            // The amount of health the player starts the game with.
	public int currentHealth;                                   // The current health the player has.
	public Slider healthSlider;                                 // Reference to the UI's health bar.
	//public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
	//public AudioClip deathClip;                                 // The audio clip to play when the player dies.
	//public float flashSpeed = 100f; //5                              // The speed the damageImage will fade at.
	//public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
	//AudioSource playerAudio;                                    // Reference to the AudioSource component.
	//bool isDead;                                                // Whether the player is dead.
	//bool damaged;                                               // True when the player gets damaged.
	
	//****************************************************************************************************
	//****************************************************************************************************	
	void Awake ()
	{
		// Setting up the references.
		//playerAudio = GetComponent <AudioSource> ();

		// Set the initial health of the player.
		currentHealth = startingHealth;
	}
	//****************************************************************************************************
	//****************************************************************************************************

	//****************************************************************************************************
	//****************************************************************************************************
	void Update ()
	{
		// If the player has just been damaged...
		//if(damaged)
		//{
			// ... set the colour of the damageImage to the flash colour.
			//damageImage.color = flashColour;
		//}
		// Otherwise...
		//else
		//{
			// ... transition the colour back to clear.
			//damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		//}
		
		// Reset the damaged flag.
		//damaged = false;
	}
	//****************************************************************************************************
	//****************************************************************************************************
	
	//****************************************************************************************************
	//****************************************************************************************************
	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash.
		//damaged = true;
		
		// Reduce the current health by the damage amount.
		currentHealth -= amount;
		
		// Set the health bar's value to the current health.
		healthSlider.value = currentHealth;
		
		// Play the hurt sound effect.
		//playerAudio.Play ();
		
		// If the player has lost all it's health and the death flag hasn't been set yet...
		//if(currentHealth <= 0 && !isDead)
		//{

			//isDead = true;
			//playerAudio.clip = deathClip;
			//playerAudio.Play ();
			//GetComponent<AudioSource>().PlayOneShot (deathClip);

			// ... it should die.
			//Death ();
		//}
	}
	//****************************************************************************************************
	//****************************************************************************************************
	
	//****************************************************************************************************
	//****************************************************************************************************
	//void Death ()
	//{

		//isDead = true;
		//playerAudio.clip = deathClip;
		//playerAudio.Play ();
		

	//}  
	//****************************************************************************************************
	//****************************************************************************************************

	//***************************************************

	//*************************************************

}