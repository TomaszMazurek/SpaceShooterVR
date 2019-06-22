using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerOnTrigger : MonoBehaviour
{
	public float damageAmount = 10.0f;
	private float cooldownTime = 1.0f;
	private bool inCooldown = false;

	private string collisionTag = "Player";

	void OnTriggerEnter(Collider col){
	Debug.Log("Damage Taken " + col.tag);

		if(!inCooldown){
		Debug.Log("NotInCD " + col.tag);
			if(col.tag == collisionTag){
			Debug.Log("Tag " + collisionTag);
				HealthManager.Instance.DamagePlayer(damageAmount);
				inCooldown = true;
				Invoke("Uncool", cooldownTime);
			}
		}
	}

	void Uncool(){
		inCooldown = false;
	}
}
