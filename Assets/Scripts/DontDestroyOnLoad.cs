using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour {



	// Use this for initialization
	void Awake(){

		DontDestroyOnLoad (transform.gameObject);

	}


}
