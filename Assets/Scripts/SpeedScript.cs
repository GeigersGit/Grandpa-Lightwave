using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpeedScript : MonoBehaviour {

    TextMesh text;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
         text = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        int temp = (int)rb.velocity.magnitude;

        text.text = temp.ToString();
	}
}
