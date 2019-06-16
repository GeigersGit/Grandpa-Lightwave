using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Rigidbody playerRB;
    float rotationSpeed = 3;
	GameObject rightAirbrake;
	GameObject leftAirbrake;

	int minAirbrakeRotation = 4;
	int maxAirbrakeRotation = 100;
	int rotationMultiplier = 25;
	float airbrakeDamping = 50f;
	Quaternion targetLeftRotation = Quaternion.identity;
	Quaternion targetRightRotation = Quaternion.identity;

	// Use this for initialization
	void Start () {
        playerRB = GetComponent<Rigidbody>();
		rightAirbrake = GameObject.Find ("Airbrake Right");
		leftAirbrake = GameObject.Find ("Airbrake Left");
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
		playerRB.angularVelocity = new Vector3(0, 0, 0);
        float rotationAmount = Input.GetAxis("Mouse X") * rotationSpeed;
        float xRotation = transform.rotation.eulerAngles.x;
        float yRotation = transform.rotation.eulerAngles.y;

        transform.Rotate(0, 0, -rotationAmount);
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z);



		//Figure out where to rotate airbrakes to
		if (rotationAmount > 0) {
			targetLeftRotation = Quaternion.Euler (minAirbrakeRotation, 0, 20);

			if (Mathf.Abs (rotationAmount) * rotationMultiplier < maxAirbrakeRotation)
				targetRightRotation = Quaternion.Euler (Mathf.Abs (rotationAmount) * rotationMultiplier, 0, -20);
			else
				targetRightRotation = Quaternion.Euler (maxAirbrakeRotation, 0, -20);
			
		} else if (rotationAmount < 0) {
			targetRightRotation = Quaternion.Euler (minAirbrakeRotation, 0, -20);

			if (Mathf.Abs (rotationAmount) * rotationMultiplier < maxAirbrakeRotation)
				targetLeftRotation = Quaternion.Euler (Mathf.Abs (rotationAmount) * rotationMultiplier, 0, 20);
			else
				targetLeftRotation = Quaternion.Euler (maxAirbrakeRotation, 0, 20);
		} else {
			targetRightRotation = Quaternion.Euler(minAirbrakeRotation, 0, -20);
			targetLeftRotation = Quaternion.Euler(minAirbrakeRotation, 0, 20);
		}


		//Move toward that rotation
		rightAirbrake.transform.localRotation = Quaternion.Lerp(rightAirbrake.transform.localRotation, targetRightRotation, Time.deltaTime * airbrakeDamping);
		leftAirbrake.transform.localRotation = Quaternion.Lerp(leftAirbrake.transform.localRotation, targetLeftRotation, Time.deltaTime * airbrakeDamping);

    }
}
