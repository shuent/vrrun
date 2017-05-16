using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomScript : MonoBehaviour {

	private int playerHP = 2;
	void Awake(){
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//RayHitAndDestroyEnemy ();
		//Debug.Log (transform.position);

	}

	void RayHitAndDestroyEnemy(){
		Ray downray = new Ray (transform.position - new Vector3(0,1,0), new Vector3(0,-2,0));
		RaycastHit hit;
		Debug.DrawRay (downray.origin, downray.direction, Color.red);

		if (Physics.Raycast (downray, out hit, 1.5f)) {
			if (hit.collider.tag == "Enemy") {
				Debug.Log ("hit enemy");
				Destroy (hit.collider.gameObject);
			}
		}
	}

	void HitEnemy (){
		playerHP -= 1;
		Debug.Log ("hp " + playerHP);
		if (playerHP <= 0) {
			GameOverScript.Excute (this.gameObject);
		}
	}




}
