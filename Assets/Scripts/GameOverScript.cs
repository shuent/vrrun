using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("player collided gameover");
			Excute (other.gameObject);
		}
	}

	void Excute(GameObject player){
		Time.timeScale = 0; // stop time scale
		Debug.Log(PlayerCanvasScript.playerCanvas);
		PlayerCanvasScript.playerCanvas.SetActive (true);
		PlayerCanvasScript.playerCanvas.GetComponentInChildren<Text> ().text = "GameOver";

	}
}
