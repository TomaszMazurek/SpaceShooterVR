using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToScoreOnTrigger : MonoBehaviour
{
	public int pointValue = 100;
	private string collisionTag = "Player";

	void OnTriggerEnter(Collider col){
		if(col.tag == collisionTag){
			ScoreManager.Instance.score += pointValue;
		}
	}
}
