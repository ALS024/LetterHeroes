using System;
using UnityEngine;
using System.Collections;


public class WordsAppear : MonoBehaviour {
    //Adriana Sawyer
    public GameObject secr;
    Sprite[] tiles = Resources.LoadAll<Sprite>("Tile");
    private var bool : boolean;
    // Use this for initialization
    void Start(){
    }
    // Update is called once per frame
    void Update(){
    }

    void OnTriggerStay2D(Collider2D collider) {
        //Sprite atiles = new Sprite;
        //if (collider.gameObject.tag == "Enemy"){
        foreach(Sprite tile in tiles){
            gameObject.layer = 2;
            bool = true;

        }
        bool = false;
        //}
        //use this if you want to switch it back after
        //else{  
        //}
    }
    function OnGUI(){
        if (bool == true){
            GUI.Button(Rect(100, 100, 500, 40), "Spell the word to defeat him!      Click to close.");
             //Debug.Log("Great Work! Onto the rest of the town!");
             bool = false;
        //end if
        }
    //end GUI funct
    }



    //end func
}
    //end class
//}
