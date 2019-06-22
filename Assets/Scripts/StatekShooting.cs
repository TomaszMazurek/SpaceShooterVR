using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatekShooting : MonoBehaviour
{	public Rigidbody bullet;
	public float bulletVelocity = 1.0f;
    public GameObject crosshairFar;
	private AudioSource mAudioSource;

	    // Start is called before the first frame update
    void Start()
    {
		mAudioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
		if(Input.GetButtonDown("Fire1")){
			Rigidbody newBullet = Instantiate(bullet, transform.position, crosshairFar.transform.rotation) as Rigidbody;
			newBullet.AddForce(crosshairFar.transform.forward * bulletVelocity, ForceMode.VelocityChange);
			mAudioSource.Play();
		}    
    }
}
