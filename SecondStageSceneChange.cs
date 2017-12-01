using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondStageSceneChange : MonoBehaviour {

	public void OnTriggerEnter2D (Collider2D coll) {

		SceneManager.LoadScene ("EasyDif3");

	}
}
