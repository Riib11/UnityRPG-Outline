using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour {

	public string[] texts;

	public bool playing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void activate() {
		if (!playing) {
			GameObject.Find ("Canvas").GetComponent<Dialogue> ().createDialogue (this.texts,this);
			playing = true;
		}
	}
}
