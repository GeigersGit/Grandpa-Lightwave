using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackScript : MonoBehaviour {
    
    //GameObject player;
    //float spawnPosition = 2105.5f;
    // Use this for initialization
	int materialIndex = 0;
	Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
	string textureName = "_MainTex";
    void Start () {
        //player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {





        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10f);

        //if (transform.position.z < -100)
        //{
            //Destroy(this.gameObject);
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + spawnPosition);
        //}
	}
}
