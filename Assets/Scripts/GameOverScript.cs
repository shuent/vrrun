using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("player collided gameover");
			StopPlayer (other.gameObject);
			// if Restart button
			//     Timescale = 1;
		}
	}

	void StopPlayer(GameObject player){
		Time.timeScale = 0;
		// player.GetComponent<Rigidbody> ().velocity = new Vector3(0, 0, 0);
	}
}
