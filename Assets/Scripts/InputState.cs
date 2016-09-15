using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {

	public bool actionButton;
	public float absVelX = 0;
	public float absVelY = 0;
	public bool standing;
	public float standingTreshold = 1;

	private Rigidbody2D body2d;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		actionButton = Input.anyKeyDown;

	}

	void FixedUpdate(){
		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);

		standing = absVelY <= standingTreshold;
	}
}
