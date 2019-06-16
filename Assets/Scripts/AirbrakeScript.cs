using UnityEngine;
using System.Collections;

public class AirbrakeScript : MonoBehaviour {

	GameObject airbrake;
	float max = 45;
	float min = 4;
	public float current = 0;

	public bool isleft = false;
	public bool isright = false;
	public bool extend = false;
	float temp = 0;

	// Use this for initialization
	void Start () {
		airbrake = GetComponent<GameObject> ();
	}

	
	// Update is called once per frame
	void Update () {
	
		extend = false;

		current = transform.rotation.eulerAngles.x;

		if (transform.rotation.eulerAngles.x >= min)
			transform.Rotate (-2, 0, 0);

		if (Input.GetKey (KeyCode.A) && isleft) 
			extend = true;

		if (Input.GetKey (KeyCode.D) && isright) 
			extend = true;

		if (extend && transform.rotation.eulerAngles.x <= max)
			transform.Rotate (5, 0, 0);
	}
}
