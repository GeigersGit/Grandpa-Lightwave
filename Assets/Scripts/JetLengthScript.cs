using UnityEngine;
using System.Collections;

public class JetLengthScript : MonoBehaviour {

    ParticleSystem PS;
    Rigidbody rb;
    GameObject player;
    //ParticleSystem.EmissionModule emission;

    // Use this for initialization
    void Start () {
        //PS =  GetComponent<ParticleSystem>();

        

        //player = GameObject.FindGameObjectWithTag("Finish");
        //rb = player.GetComponent<Rigidbody>();

        //emission = PS.emission;
        //emission.enabled = true;

        //PS.startSpeed = 40;
    }
	
	// Update is called once per frame
	void Update () {
        //if (PS.startSpeed < 150)
        //PS.startSpeed = 40 + (rb.velocity.magnitude/60);
    }
}
