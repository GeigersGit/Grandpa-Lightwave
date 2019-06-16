using UnityEngine;
using System.Collections;



public class BobbingScript : MonoBehaviour {
	float x = 0;
	float y = 0;
	public float y_scale = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x += Time.deltaTime;
		y = Mathf.Sin (x);
		transform.position = new Vector3 (transform.position.x,transform.position.y + (y/y_scale), transform.position.z);
	}
}
