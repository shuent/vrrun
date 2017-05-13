using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("player collided gameClear");

			//
			Time.timeScale = 0;
			gameObject.SetActive (false);
			PlayerCanvasScript.playerCanvas.SetActive (true);
			PlayerCanvasScript.playerCanvas.GetComponentInChildren<Text> ().text = "GameClear!";
		}
	}
}
