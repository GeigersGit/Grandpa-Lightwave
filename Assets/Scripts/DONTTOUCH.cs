using UnityEngine;
using System.Collections;

public class DONTTOUCH : MonoBehaviour {

	public Transform explosion;

	// Use this for initialization
	void Start () {
		
	
	}


	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == ("Player")){
			Vector3 position = col.gameObject.transform.position;
			Quaternion rotation = col.gameObject.transform.rotation;

			Destroy (col.gameObject);
			Instantiate (explosion, position, rotation);

			//Wait ();

			Application.LoadLevel (3);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (3);
	}

}
