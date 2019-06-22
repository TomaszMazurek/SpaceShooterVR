using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{	public float movementSpeed = 1.0f;
	private int invert = -1;
	private Vector3 direction;
	private float yaw;
	private float pitch;
	private float roll;
    // Update is called once per frame
    void Update()
    {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		float rollAxis = Input.GetAxis("Mouse X");
		
		float smooth = 0.5f;
		float tiltAngle = 60.0f;

		//point = new Vector3(horizontal, vertical, 0);
		//Debug.Log(point);

		//direction = new Vector3(invert * vertical, horizontal, roll);
		//Debug.Log(direction);
		//Vector3 finalDirection = new Vector3(horizontal, invert * vertical, 0.0f);
		//direction *= movementSpeed * Time.deltaTime;
        //transform.position += direction * movementSpeed * Time.deltaTime;

		//transform.rotation = Quaternion.Euler(, horizontal * invert, roll);
		//transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), Mathf.Deg2Rad*5.0f);
		float tiltAroundZ = horizontal * tiltAngle;
        float tiltAroundX = vertical * tiltAngle;
		float tiltAroundY = rollAxis * tiltAngle * 2 * invert;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, tiltAroundZ, tiltAroundY * 10);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

		//transform.Rotate(vertical * Mathf.PI, horizontal * Mathf.PI, invert * roll * 2 * Mathf.PI, Space.Self);
		//Debug.Log(transform.rotation);
    }
}
