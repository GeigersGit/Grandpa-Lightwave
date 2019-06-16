using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EvironmentMovement : MonoBehaviour {
	public Rigidbody rb;
	public int speed = 1000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "Main Scene") {
			rb.drag = 0;
			rb.AddRelativeForce (0, 0, -speed);
		}
		else
			rb.drag = 100;
	}
}
