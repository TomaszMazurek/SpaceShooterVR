using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnEnter : MonoBehaviour
{
	public string[] tags;
	public GameObject gib;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider col){
		foreach(string tag in tags){
			if(col.tag == tag){
				Instantiate(gib, transform.position,  Random.rotation);
				Destroy(gameObject); 
			}
		}
	}
}
