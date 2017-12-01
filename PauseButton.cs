using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {

	[SerializeField]
	private GameObject panel;

	public void PauseGame(){

		Time.timeScale = 0f;

		panel.SetActive (true);
	}

	public void ResumeGame(){

		Time.timeScale = 1f;

		panel.SetActive (false);
	}

	public void QuitGame(){

		SceneManager.LoadScene ("MainMenu");
		Time.timeScale = 1f;
	}
}
