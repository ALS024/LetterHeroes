using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public static float offsetX;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		MoveTheCamera ();
	}

	void MoveTheCamera() {
		Vector3 temp = transform.position;
		temp.x = PlayerScript.instance.GetPositionX () + offsetX;
		temp.y = PlayerScript.instance.GetPositionY() + 1.1f;
		transform.position = temp;
	}
}
