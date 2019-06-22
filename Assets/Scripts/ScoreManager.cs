using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

	public int score = 0;
	Text txt;
	
	private static ScoreManager instance =  null;
	public static ScoreManager Instance {
		get { return instance; }
	}
	
	void Awake(){
		if(instance != null && instance != this){
			Destroy(this.gameObject);
			return;
		} else{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
		gameObject.name = "$ScoreManager";
		GameObject dashboard = GameObject.Find("OverlayText");
		txt = dashboard.transform.GetComponent<Text>();
		}

	void Update(){

		txt.text = "Score: " + score.ToString() + "\n";
	}
}
