using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToScoreOnDestroy : MonoBehaviour
{
	public int pointValue = 1000;

	void Start(){
			ScoreManager.Instance.score += pointValue;
	}
}
