﻿using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public int startingHealth = 100;                            // The amount of health the player starts the game with.
	public int currentHealth;                                   // The current health the player has.
	public AudioClip deathClip;                                 // The audio clip to play when the player dies.
	public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
	
	
	Animator anim;                                              // Reference to the Animator component.
	AudioSource playerAudio;                                    // Reference to the AudioSource component.                             // Reference to the PlayerShooting script.
	bool isDead;                                                // Whether the player is dead.
	bool damaged;                                               // True when the player gets damaged.
	
	
	void Awake ()
	{
		// Setting up the references.
		anim = GetComponent <Animator> ();
		playerAudio = GetComponent <AudioSource> ();
		
		// Set the initial health of the player.
		currentHealth = startingHealth;
	}
	
	
	void Update ()
	{
		// If the player has just been damaged...
		if (damaged) {
				}
					
		// Reset the damaged flag.
		damaged = false;
	}
	
	
	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash.
		damaged = true;
		
		// Reduce the current health by the damage amount.
		currentHealth -= amount;
		
		// Set the health bar's value to the current health.
	
		
		// Play the hurt sound effect.
		playerAudio.Play ();
		
		// If the player has lost all it's health and the death flag hasn't been set yet...
		if(currentHealth <= 0 && !isDead)
		{
			// ... it should die.
			Death ();
		}
	}
	
	
	void Death ()
	{
		// Set the death flag so this function won't be called again.
		isDead = true;
		// Tell the animator that the player is dead.
		anim.SetTrigger ("Die");
		
		// Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
		playerAudio.clip = deathClip;
		playerAudio.Play ();
		

	}       
}