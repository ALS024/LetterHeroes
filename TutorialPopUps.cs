using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPopUps : MonoBehaviour {

	public static int clickCount = 0;

	[SerializeField]
	private GameObject tutorialBtn;

	// Use this for initialization
	void Awake () {
		Time.timeScale = 0f;
	}
	
	public void Clicked(){
	
		if (clickCount == 0) {
			tutorialBtn.GetComponentInChildren<Text> ().text = " Approach the zombie to see his word \n\nClick to continue";
			clickCount++;
			Debug.Log (clickCount);
		}else if(clickCount == 1){
			Time.timeScale = 1f;
		}else if( clickCount == 2){
			tutorialBtn.GetComponentInChildren<Text> ().text = " We have to unscramble them! \nMaybe try clicking them in the right order? \n\nClick to continue";
			clickCount++;
			Time.timeScale = 1f;
			Debug.Log (clickCount);
		}else if( clickCount == 3){
			tutorialBtn.GetComponentInChildren<Text> ().text = " Go on, give it a try.";
			clickCount++;
			Debug.Log (clickCount);
		}
		
	}
}
