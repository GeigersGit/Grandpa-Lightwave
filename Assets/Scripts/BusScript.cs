using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (2500f * Time.deltaTime));

        if (transform.position.z < -100)
        {
            Destroy(this.gameObject);
            
        }
    }

}
