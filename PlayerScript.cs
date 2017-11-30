using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public static PlayerScript instance;

	public float speed = 8f, maxVelocity = 4f;
	private Rigidbody2D myBody;
	private Animator anim;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

		if (instance == null) {
			instance = this;
		}
	}

	void Start () {

	}

	void FixedUpdate () {
		PlayerWalkKeyboard ();
	}

	void SetCamerasX() {
		CameraScript.offsetX = (Camera.main.transform.position.x - transform.position.x) - 1f;
	}

	public float GetPositionX() {
		return transform.position.x;
	}

	public float GetPositionY() {
		return transform.position.y;
	}

	void PlayerWalkKeyboard() {
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");

		if (h > 0) {

			if (vel < maxVelocity)
				forceX = speed;

			Vector3 temp = transform.localScale;
			temp.x = .3f;
			transform.localScale = temp;

			anim.SetBool ("Walk", true);

		} else if (h < 0) {

			if (vel < maxVelocity)
				forceX = -speed;

			Vector3 temp = transform.localScale;
			temp.x = -.3f;
			transform.localScale = temp;

			anim.SetBool ("Walk", true);

		} else {
			anim.SetBool ("Walk", false);
		}

		myBody.AddForce (new Vector2(forceX, 0));

	}

} // Player