using UnityEngine;
using System.Collections;

public class UpwardThrusterScript : MonoBehaviour {
	ParticleSystem PS;
	// Use this for initialization
	void Start () {
		PS = GetComponent<ParticleSystem>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			PS.startSpeed = 40;
		}
		else PS.startSpeed = 10;
	}
}
