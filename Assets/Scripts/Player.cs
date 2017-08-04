using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float moveSpeed = 2f;
	float range = 0.25f;

	Vector2 facing;
	Rigidbody2D rb;

	public bool canMove = true;

	// Use this for initialization
	void Start () {
		this.rb = this.GetComponent<Rigidbody2D> ();
		this.facing = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
		// don't move
		if (!this.canMove) { return; }

		// movement
		Vector2 m = Vector2.zero;
		if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { m.x = -1f; } else
		if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { m.x = 1f; }
		if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { m.y = 1f; } else
		if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { m.y = -1f; }
		if (m.x != 0 && m.y != 0) { m *= 1 / Mathf.Sqrt (2); }
		this.rb.velocity = m * this.moveSpeed;

		if (m.x != 0) { this.facing.x = m.x; this.facing.y = 0; }
		if (m.y != 0) { this.facing.y = m.y; this.facing.x = 0; }


		Debug.DrawLine (this.transform.position, this.transform.position + range * (new Vector3 (this.facing.x, this.facing.y, 0)));

		// interact
		if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.Return)) {
			RaycastHit2D hit = Physics2D.Raycast (this.transform.position, this.facing, range);
			if (hit.collider && hit.collider.gameObject.layer == 8) {
				hit.collider.gameObject.GetComponent<InteractController> ().activate ();
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		
	}
}
