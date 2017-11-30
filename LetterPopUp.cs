using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterPopUp : MonoBehaviour {

	[SerializeField]
	private GameObject letterBtn1, letterBtn2, letterBtn3, letterBtn4, letterBtn5, letterBtn6, letterBtn7, letterBtn8;

	[SerializeField]
	private Animator anim1, anim2, anim3, anim4, anim5, anim6, anim7, anim8;

	[SerializeField]
	private GameObject blankBox, blankBox2;

	[SerializeField]
	private GameObject tutorialBtn;

	public void OnTriggerEnter2D (Collider2D coll) {

		letterBtn5.SetActive (true);
		letterBtn6.SetActive (true);
		letterBtn7.SetActive (true);
		letterBtn8.SetActive (true);

		anim1.Play ("FadeIn");
		anim2.Play ("FadeIn");
		anim3.Play ("FadeIn");
		anim4.Play ("FadeIn");
		anim5.Play ("FadeIn");
		anim6.Play ("FadeIn");
		anim7.Play ("FadeIn");
		anim8.Play ("FadeIn");

		blankBox.SetActive (true);
		blankBox2.SetActive (true);

		tutorialBtn.GetComponentInChildren<Text> ().text = " Oh no! His word is scramled! \n\nClick to continue";
		TutorialPopUps.clickCount++;
		StartCoroutine (WaitThenPause ());
		Debug.Log (TutorialPopUps.clickCount);
	}

	IEnumerator WaitThenPause(){
	
		yield return new WaitForSeconds (1f);
		Time.timeScale = 0f;
	}
}
