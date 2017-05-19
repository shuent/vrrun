using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	AudioSource gameOverSound;

	public static GameOverScript instance = null;
	void Awake(){
		if (instance == null) {
			instance = this;
		}

		gameOverSound = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("player collided gameover");
			Excute (other.gameObject);

			// rigid body stop
			var rb = other.gameObject.GetComponent<Rigidbody>();
			rb.velocity = Vector3.zero;
			rb.isKinematic = true;
		}
	}

	public void Excute(GameObject player){
//		Time.timeScale = 0; // stop time scale

		gameOverSound.Play ();

		Debug.Log(PlayerCanvasScript.playerCanvas);
		PlayerCanvasScript.playerCanvas.SetActive (true);
		PlayerCanvasScript.playerCanvas.GetComponentInChildren<Text> ().text = "GameOver";


		Invoke ("RestartScene", 6f);
	}

	void RestartScene(){
		SceneManager.LoadScene(0);
		Resources.UnloadUnusedAssets();
//		Time.timeScale = 1;
	}
}
