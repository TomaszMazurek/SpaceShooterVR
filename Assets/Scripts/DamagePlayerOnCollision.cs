using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerOnCollision : MonoBehaviour
{
	public float damageAmount = 10.0f;
	private float cooldownTime = 1.0f;
	private bool inCooldown = false;

	void OnCollisionEnter(){
		HealthManager.Instance.DamagePlayer(damageAmount);
		inCooldown = true;
		Invoke("Uncool", cooldownTime);
	}

	void Uncool(){
		inCooldown = false;
	}
}
