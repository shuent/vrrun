using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	// activated by GameCollider
	void Update () {
		FixPosition ();

	}

	void FixPosition(){
		Vector3 pos = transform.position;
		pos.x = -3 + Camera.main.transform.position.x;
		pos.y = 0 + Camera.main.transform.position.y;
		pos.z = 0 + Camera.main.transform.position.z;
		transform.position = pos;
	}
}
