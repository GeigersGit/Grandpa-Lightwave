using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public GameObject busPrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBus", 2.0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void SpawnBus() {
        float xPos = Random.Range(-45.0f, 45.0f);
        float yPos = Random.Range(15.0f, 80.0f);
        Instantiate(busPrefab, new Vector3(xPos, yPos, 2105.5f), Quaternion.identity);
    }
}
