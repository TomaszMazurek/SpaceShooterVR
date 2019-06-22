using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
	public int health = 0;
	Text txt;
	public float maxHealth = 100.0f;
	private float currentHealth;

	private static HealthManager instance =  null;
	public static HealthManager Instance {
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
		gameObject.name = "$HealthManager";
		GameObject dashboard = GameObject.Find("OverlayText");
		txt = dashboard.GetComponent<Text>();
		}

		void Start(){
			currentHealth = maxHealth;
		}

		void Update(){
			txt.text = txt.text + "Ship Integrity: " + currentHealth.ToString() + "\n";
		}

		public void DamagePlayer(float damageAmount){
			if(damageAmount < 0){
				return;
			}

			currentHealth -= damageAmount;

			if(currentHealth <= 0) {
				//GameOver logic here or live count;
			}
		}

		public void RestoreHealth(float healthAmount){
			if(healthAmount < 0){
				return;
			}

			currentHealth += healthAmount;

			if(currentHealth > maxHealth) {
				currentHealth = maxHealth;
			}
		}

}
