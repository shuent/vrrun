using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	public void RestartMain(){
		Debug.Log (SceneManager.GetActiveScene().buildIndex);
		SceneManager.LoadScene(0);
		Time.timeScale = 1;
	}


}
