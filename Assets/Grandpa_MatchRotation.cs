using UnityEngine;
using System.Collections;

public class Grandpa_MatchRotation : MonoBehaviour {

	public GameObject gb_matchingObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = gb_matchingObject.transform.rotation;
	
	}
}
