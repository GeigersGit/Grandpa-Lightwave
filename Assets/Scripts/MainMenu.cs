using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	GameObject env;
    Vector3 startpos;

	public bool isPlayButton = false;
	public bool isCreditsButton = false;
	public bool isExitButton = false;
	public bool isMainMenuButton = false;
	public bool isplayagainbutton = false;
	public GameObject creditsPrefab;
	bool hover = false;

	// Use this for initialization
	void Start () {
		startpos = new Vector3 (-32, 55, 18039);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			Application.LoadLevel (1);
			env = GameObject.Find ("Environment");
			env.transform.position = startpos;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}


		if (hover) {
			if (Input.GetMouseButtonDown (0)) {
				
				if (isPlayButton) {
					Application.LoadLevel (1);
					env = GameObject.Find ("Environment");
					env.transform.position = startpos;
				}
				if (isCreditsButton)
					Instantiate(creditsPrefab, new Vector3(-30, 133, -3851), Quaternion.identity);
				if (isExitButton)
					Application.Quit ();
				if (isMainMenuButton)
					Application.LoadLevel (0);
				if(isplayagainbutton){
					Application.LoadLevel(1);

				}
			}
		}
	}

	void OnMouseEnter(){
		hover = true;
	}
	void OnMouseExit(){
		hover = false;
	}

}
