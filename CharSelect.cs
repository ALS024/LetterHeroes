using System;
using UnityEngine;

// Loads Char sprites from Resources folder
// and allows them to be chosen by the selection button.
//Adriana Sawyer

public class CharSelect : MonoBehaviour
{
    private string spriteNames = "Hero";
    private Rect buttonPos;
    private int spriteVersion = 0;
    private SpriteRenderer spriteR;
    private Sprite[] sprites;

    void Start()
    {
        buttonPos = new Rect(10.0f, 10.0f, 150.0f, 50.0f);
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(spriteNames);
    }

    void OnGUI()
    {
        if (GUI.Button(buttonPos, "Choose next sprite"))
        {
            spriteVersion += 1;
            if (spriteVersion > 3)
                spriteVersion = 0;
            spriteR.sprite = sprites[spriteVersion];
        }
    }
}
}
