using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class VisCreate : MonoBehaviour {

	public GameObject visprefab;
	public Transform spawnpoint;

	Vector3 nextSpawn;

	// Use this for initialization
	void Start () {
		findNextSpawn ();
	}

	void findNextSpawn(){

		nextSpawn = new Vector3 (
			transform.parent.transform.position.x,
			transform.parent.transform.position.y,
			transform.parent.transform.position.z + 500);
	}
	// Update is called once per frame
	void Update () {

		if (SceneManager.GetActiveScene ().name == "PlayAgain") {
			//transform.parent.position = spawnpoint;


		}
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {

			transform.parent.position = nextSpawn;
			findNextSpawn ();
			//GameObject go = (GameObject)Instantiate 
				//(visprefab, nextSpawn, transform.parent.transform.rotation);
			//GameObject go2 = GameObject.Find ("Environment");
			//go.transform.parent = go2.transform;
			//Destroy (transform.parent.gameObject);
		}

	}
}
