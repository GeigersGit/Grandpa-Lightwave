using UnityEngine;
using System.Collections;

public class TextScroll : MonoBehaviour {
	Vector3 position;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		position = new Vector3 (transform.position.x, transform.position.y - 0.1f, transform.position.z);
		transform.position = position;

		if (transform.position.y < -50)
			Destroy (this.gameObject);
	}
}
