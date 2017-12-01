using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour {

	[SerializeField]
	private GameObject completePanel;

	public void OnTriggerEnter2D(){

		completePanel.SetActive (true);

		Time.timeScale = 0f;

	}
}
