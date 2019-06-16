using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

    public GameObject busPrefab;
	public Material mat;
	string textureName = "_MainTex";
	Vector2 uvAnimationRate = new Vector2( 0.0f, -2500.0f );
	Vector2 uvOffset = Vector2.zero;
	public GameObject player;
	public GameObject restartMenu;
	public bool died = false;
	Vector3 location = new Vector3(0, 0, 0);
	public TextMesh timeText;

	int minutes = 0;
	float seconds = 0;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBus", 2.0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

		uvOffset += (uvAnimationRate * Time.deltaTime);
		mat.SetTextureOffset (textureName, uvOffset);

		if (player) {
			location = player.transform.position;

			seconds += Time.deltaTime;
			if (seconds > 60) {
				seconds = 0;
				minutes += 1;
			}

			if (seconds < 10) {
				timeText.text = "Survived: " + minutes + ":0" + seconds.ToString("F0");
			}
			else{
				timeText.text = "Survived: " + minutes + ":" + seconds.ToString("F0");
			}

		}

		if (!player && died == false) {
			died = true;
			GameObject camera = GameObject.Find ("Main Camera");
			Instantiate (restartMenu, location, Quaternion.identity);
		}
    }

    void SpawnBus() {
        float xPos = Random.Range(-45.0f, 45.0f);
        float yPos = Random.Range(15.0f, 80.0f);
        Instantiate(busPrefab, new Vector3(xPos, yPos, 4105.5f), Quaternion.identity);
    }
}
