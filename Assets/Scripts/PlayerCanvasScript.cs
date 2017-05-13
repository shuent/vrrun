using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasScript : MonoBehaviour {

	static public GameObject playerCanvas;

	void Awake(){
		playerCanvas = this.gameObject;
		gameObject.SetActive (false);
	}


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	// activated by GameCollider
	void Update () {
		FixPosition ();

	}

	void FixPosition(){
		transform.position = Camera.main.transform.position + new Vector3(-3,1,0);
	}

}
