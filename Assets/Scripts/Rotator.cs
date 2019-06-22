using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float angularVelocity = 1.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 , angularVelocity * Time.deltaTime * Mathf.PI, 0, Space.Self);
    }
}
