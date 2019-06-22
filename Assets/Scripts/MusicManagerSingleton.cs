using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MusicManagerSingleton : MonoBehaviour
{
	private static MusicManagerSingleton instance =  null;
	public static MusicManagerSingleton Instance {
		get { return instance; }
	}

	private AudioSource audioSource;
	void Awake(){
		if(instance != null && instance != this){
		instance.gameObject.SendMessage("SetMusic", audioSource.clip);
			Destroy(this.gameObject);
			return;
		} else{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
		gameObject.name = "$MusicManagerSingleton";
		}

	public void SetMusic(AudioClip newClip){
		if(newClip !=  null){
			if(audioSource.clip != newClip){
				audioSource.clip = newClip;
				audioSource.Play();
			}
		} else {
			audioSource.Stop();
			audioSource.clip = null;
		}
	}

}
