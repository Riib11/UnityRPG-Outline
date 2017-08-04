using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueArrowController : MonoBehaviour {

	RectTransform t;
	float x;
	float y;

	// Use this for initialization
	void Start () {
		this.t = this.GetComponent<RectTransform> ();
		this.x = this.t.localPosition.x;
		this.y = this.t.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		t.localPosition = new Vector3 (this.x, this.y + Mathf.PingPong (Time.time*15, 8), 0f);
	}
}
