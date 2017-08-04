using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour {

	public string[] texts;
	public int index;
	public InteractController ic;


	// Use this for initialization
	void Start () {
		this.index = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.index < this.texts.Length) {
			this.GetComponentInChildren<Text> ().text = this.texts [this.index];
		} else {
			ic.playing = false;
			GameObject.Find ("Player").GetComponent<Player> ().canMove = true;
			GameObject.DestroyImmediate (this.gameObject);
		}

		if (Input.GetKeyDown (KeyCode.E) || Input.GetKeyDown (KeyCode.Return)) {
			this.index++;
		}
	}
}
