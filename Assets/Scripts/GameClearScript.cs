using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour {

	AudioSource gameClearSound;

	void Start(){
		gameClearSound = GetComponent<AudioSource> ();
//		gameClearSound.Play ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("player collided gameClear");

			gameClearSound.Play ();

			// rigid body stop
			var rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector3.zero;
			rb.isKinematic = true;

			GetComponent<Renderer> ().enabled = false;
			PlayerCanvasScript.playerCanvas.SetActive (true);

			PlayerCanvasScript.playerCanvas.GetComponentInChildren<Text> ().text = "GameClear!";
			Invoke ("RestartScene", 6f);
		}
	}

	void RestartScene(){
		SceneManager.LoadScene(0);
		Resources.UnloadUnusedAssets();
//		Time.timeScale = 1;
	}
}
