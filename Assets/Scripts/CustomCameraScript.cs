using UnityEngine;
using System.Collections;

public class CustomCameraScript : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.position.x/1.1f ,10 + target.position.y/1.5f, target.position.z - 15);
	}
}
