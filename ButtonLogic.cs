using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour {

	[SerializeField]
	private  GameObject blank1, blank2, blank3, blank4, letter1, letter2, letter3, letter4;

	[SerializeField]
	private Animator blankAnim1, blankAnim2, blankAnim3, blankAnim4, letterAnim1, letterAnim2, letterAnim3, letterAnim4;

	[SerializeField]
	private GameObject blankBox, blankBox2, blankBox3;

	[SerializeField]
	private Animator enemyAnim;

	[SerializeField]
	private GameObject tutorialBtn;

	private int currentPress = 0;
	private int nextPress = 1;
	private int clicksLeft = 100;

	[SerializeField]
	private bool allPressedCorrectly = false;


	public void PressedLetter1(){

		currentPress = 1;

		if (currentPress == nextPress) {
			nextPress = 2;
			letter1.transform.position = blank1.transform.position;
		} else {
			currentPress = 0;
			nextPress = 1;
		}
	}

	public void PressedLetter2(){

		currentPress = 2;

		if (currentPress == nextPress) {
			nextPress = 3;
			letter2.transform.position = blank2.transform.position;
		} else {
			currentPress = 0;
			nextPress = 1;
		}
	}

	public void PressedLetter3(){

		currentPress = 3;

		if (currentPress == nextPress) {
			nextPress = 4;
			letter3.transform.position = blank3.transform.position;
		} else {
			currentPress = 0;
			nextPress = 1;
		}
	}

	public void PressedLetter4(){

		currentPress = 4;

		if (currentPress == nextPress) {

			letter1.transform.position = blank1.transform.position;
			letter2.transform.position = blank2.transform.position;
			letter3.transform.position = blank3.transform.position;
			letter4.transform.position = blank4.transform.position;		

			allPressedCorrectly = true;

			blankAnim1.Play ("FadeOut");
			blankAnim2.Play ("FadeOut");
			blankAnim3.Play ("FadeOut");
			blankAnim4.Play ("FadeOut");
			letterAnim1.Play ("FadeOut");
			letterAnim2.Play ("FadeOut");
			letterAnim3.Play ("FadeOut");
			letterAnim4.Play ("FadeOut");
			enemyAnim.Play ("EnemyPassOut");

			blankBox.SetActive (false);
			blankBox2.SetActive (false);
			blankBox3.SetActive (false);

			StartCoroutine (WaitThenPause ());

			letter1.SetActive (false);
			letter2.SetActive (false);
			letter3.SetActive (false);
			letter4.SetActive (false);

			currentPress = 0;
			nextPress = 1;

		} else {
			currentPress = 0;
			nextPress = 1;
		}
	}

	IEnumerator WaitThenPause(){

		yield return new WaitForSeconds (1f);
		tutorialBtn.GetComponentInChildren<Text> ().text = " You did it! Now its time to defeat the others \nand take our words back!";
	}
}
