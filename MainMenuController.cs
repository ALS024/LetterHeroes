using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	// Opens the game level
	public void StartGame (){
		SceneManager.LoadScene("EasyDif");
	}
	/*
	// Opens High Score Scene
	public void HighScoreScreen (){
	}

	// Easy difficulty
	public void EasyToggle (){
	}

	// Medium difficulty
	public void MediumToggle (){
	}

	// Hard difficulty
	public void HardToggle (){
	}

	public void QuitGame (){
		Application.Quit ();
	}
	*/
}
