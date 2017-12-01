using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	[SerializeField]
	public Text scoreText;

	[SerializeField]
	private GameObject gameOverPanel;

	private int score = 50;

	public void SetScore(){
		score--;
		scoreText.text = "" + score;

		if(score == 0){
			gameOverPanel.SetActive (true);
		}
	}
}
