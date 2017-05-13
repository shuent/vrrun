using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isSteppedCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("this is stepped1");
			var _parent = transform.root.gameObject;
			Destroy (_parent);
		}
	}
}
