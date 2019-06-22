using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
	public float targetDistance = 20.0f;
	public float speed = 10.0f;         //Move speed
	public float swayMagnitude = 10f;
	public float swaySpeed = 10.0f;
	public float fireRate = 0.5f;
	private float nextFire = 0.0f;
	private Vector3 Distance;
	private float DistanceFrom;
	public Rigidbody enemyBullet;
	public float bulletVelocity = 1.0f;
	GameObject player;
	Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
        newPosition = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
		newPosition = transform.position;

        if((player.transform.position - transform.position).magnitude < targetDistance){
			newPosition.z = player.transform.position.z + targetDistance;
			Attacking();
		}
			newPosition.x = player.transform.position.x + Mathf.Sin(Time.time * swaySpeed ) * swayMagnitude ;
			newPosition.y = player.transform.position.y - Mathf.Cos(Time.time * swaySpeed) * swayMagnitude;
			transform.position = newPosition;           
    }

	void Attacking(){

		if(Time.time > nextFire){
			nextFire = Time.time + fireRate;
			transform.LookAt(player.transform);
			Rigidbody newBullet = Instantiate(enemyBullet, transform.position, transform.rotation) as Rigidbody;
			newBullet.AddForce(transform.forward * bulletVelocity, ForceMode.VelocityChange);
		}
	}
}
