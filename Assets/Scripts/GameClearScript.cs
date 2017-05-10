using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("player collided gameClear");
			SceneManager.LoadScene ("gameClear");
		}
	}
}
