using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{	
	public GameObject[]  spawnObjects;
	public GameObject ship;
	public float xRange = 1.0f;
	public float yRange = 1.0f;
	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
		Invoke("SpawnObject", Random.Range(minSpawnTime, maxSpawnTime));     
    }

	void SpawnObject(){
		transform.position = new Vector3(0,0, ship.transform.position.z + 200);
		float xOffset = Random.Range(-xRange, xRange);
		float yOffset = Random.Range(-yRange, yRange);
		int spawnObjectIdx = Random.Range(0, spawnObjects.Length);
		Debug.Log("SPAWN " + spawnObjects[spawnObjectIdx].name);
		Instantiate(spawnObjects[spawnObjectIdx], transform.position + new Vector3(xOffset, yOffset, 0.0f), spawnObjects[spawnObjectIdx].transform.rotation);
		Invoke("SpawnObject", Random.Range(minSpawnTime, maxSpawnTime));
	}
}
