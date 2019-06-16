using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Rigidbody playerRB;
    float rotationSpeed = 3;

	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody>();
        //MousePositionX = Input.mousePosition.x;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            playerRB.AddRelativeForce(0, 350, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 7);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -7);
        }

        //Rotate by difference between last mouse position and current mouse position
        float rotationAmount = Input.GetAxis("Mouse X") * rotationSpeed;
        float xRotation = transform.rotation.eulerAngles.x;
        float yRotation = transform.rotation.eulerAngles.y;

        transform.Rotate(0, 0, -rotationAmount);

        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z);



    }
}
