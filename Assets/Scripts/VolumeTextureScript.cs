using UnityEngine;
using System.Collections;

public class VolumeTextureScript : MonoBehaviour {


	public GameObject visualizer;
	MonoBehaviour playerscript;
	public Material mat;
    //public Material mat2;
    //public Material mat3;
    int scaler = 30;
    //Renderer render;
    public Circle64 targetscript;
	public float volume = 0;
	// Use this for initialization
	void Start () {
		visualizer = GameObject.Find ("Music Analyzer");
		targetscript = visualizer.GetComponent<Circle64>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!targetscript) {
			visualizer = GameObject.Find ("Music Analyzer");
			targetscript = visualizer.GetComponent<Circle64>();
		}
		volume = targetscript.averagevol;
		//DynamicGI.SetEmissive (GetComponent<Renderer>(), new Color (volume*10f, volume*10f, volume*10f, volume*10f));

		mat.SetColor ("_EmissionColor", new Color (volume* scaler, volume* scaler, volume* scaler));

    }
}
